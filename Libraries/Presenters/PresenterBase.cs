﻿/* ------------------------------------------------------------------------- */
///
/// Copyright (c) 2010 CubeSoft, Inc.
/// 
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///  http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
///
/* ------------------------------------------------------------------------- */
using System;
using System.Threading;
using System.Threading.Tasks;
using Cube.Log;

namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// PresenterBase
    ///
    /// <summary>
    /// View のみを保持する Presenter の基底となるクラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class PresenterBase<TView> : IDisposable
    {
        #region Constructors and destructors

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        /// 
        /// <param name="view">View オブジェクト</param>
        ///
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view)
            : this(view, null)
        { }

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        /// 
        /// <param name="view">View オブジェクト</param>
        /// <param name="events">EventAggregator オブジェクト</param>
        ///
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, IEventAggregator events)
            : this(view, events, SynchronizationContext.Current)
        { }

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="events">EventAggregator オブジェクト</param>
        /// <param name="context">同期コンテキスト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, IEventAggregator events, SynchronizationContext context)
        {
            View                   = view;
            EventAggregator        = events;
            SynchronizationContext = context;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ~PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを破棄します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        ~PresenterBase()
        {
            Dispose(false);
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// View
        /// 
        /// <summary>
        /// View オブジェクトを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public TView View { get; private set; }

        /* ----------------------------------------------------------------- */
        ///
        /// EventAggregator
        /// 
        /// <summary>
        /// EventAggregator オブジェクトを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public IEventAggregator EventAggregator { get; set; }

        /* --------------------------------------------------------------------- */
        ///
        /// SynchronizationContext
        /// 
        /// <summary>
        /// オブジェクト初期化時のコンテキストを取得します。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public SynchronizationContext SynchronizationContext { get; }

        #endregion

        #region Methods

        /* --------------------------------------------------------------------- */
        ///
        /// Async
        /// 
        /// <summary>
        /// 各種操作を非同期で実行します。
        /// </summary>
        /// 
        /// <param name="action">
        /// 非同期で実行する <c>Action</c> オブジェクト
        /// </param>
        ///
        /* --------------------------------------------------------------------- */
        public Task Async(Action action) => Task.Run(() => action());

        /* --------------------------------------------------------------------- */
        ///
        /// Async
        /// 
        /// <summary>
        /// 各種操作を非同期で実行します。
        /// </summary>
        /// 
        /// <param name="func">
        /// 非同期で実行する <c>Func(TResult)</c> オブジェクト
        /// </param>
        ///
        /* --------------------------------------------------------------------- */
        public Task<TResult> Async<TResult>(Func<TResult> func) => Task.Run(() => func());

        /* --------------------------------------------------------------------- */
        ///
        /// Sync
        /// 
        /// <summary>
        /// オブジェクト初期化時のスレッド上で各種操作を実行します。
        /// </summary>
        /// 
        /// <param name="action">
        /// 同期コンテキスト上で実行する <c>Action</c> オブジェクト
        /// </param>
        ///
        /* --------------------------------------------------------------------- */
        public void Sync(Action action)
            => this.LogException(() => SynchronizationContext.Post(_ => action(), null));

        /* --------------------------------------------------------------------- */
        ///
        /// SyncWait
        /// 
        /// <summary>
        /// オブジェクト初期化時のスレッド上で各種操作を実行し、
        /// 実行が完了するまで待機します。
        /// </summary>
        /// 
        /// <param name="action">
        /// 同期コンテキスト上で実行する <c>Action</c> オブジェクト
        /// </param>
        ///
        /* --------------------------------------------------------------------- */
        public void SyncWait(Action action)
            => this.LogException(() => SynchronizationContext.Send(_ => action(), null));

        /* --------------------------------------------------------------------- */
        ///
        /// SyncWait
        /// 
        /// <summary>
        /// オブジェクト初期化時のスレッド上で各種操作を実行し、
        /// 実行が完了するまで待機します。
        /// </summary>
        /// 
        /// <param name="func">
        /// 同期コンテキスト上で実行する <c>Func(TResult)</c> オブジェクト
        /// </param>
        ///
        /* --------------------------------------------------------------------- */
        public TResult SyncWait<TResult>(Func<TResult> func)
        {
            TResult result = default(TResult);
            try { SynchronizationContext.Send(_ => { result = func(); }, null); }
            catch (Exception err) { this.LogError(err.Message, err); }
            return result;
        }

        #endregion

        #region Methods for IDisposable

        /* ----------------------------------------------------------------- */
        ///
        /// Dispose
        /// 
        /// <summary>
        /// オブジェクトを破棄する際に必要な終了処理を実行します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Dispose
        /// 
        /// <summary>
        /// オブジェクトを破棄する際に必要な終了処理を実行します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected virtual void Dispose(bool disposing) { }

        #endregion
    }

    /* --------------------------------------------------------------------- */
    ///
    /// PresenterBase
    ///
    /// <summary>
    /// View と Model が 1 対 1 対応する Presenter の基底となるクラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class PresenterBase<TView, TModel> : PresenterBase<TView>
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="model">Model オブジェクト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, TModel model)
            : base(view)
        {
            Model = model;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="model">Model オブジェクト</param>
        /// <param name="events">EventAggregator オブジェクト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, TModel model, IEventAggregator events)
            : base(view, events)
        {
            Model = model;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="model">Model オブジェクト</param>
        /// <param name="events">EventAggregator オブジェクト</param>
        /// <param name="context">同期コンテキスト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, TModel model,
            IEventAggregator events, SynchronizationContext context)
            : base(view, events, context)
        {
            Model = model;
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Model
        /// 
        /// <summary>
        /// Model オブジェクトを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public TModel Model { get; private set; }

        #endregion
    }

    /* --------------------------------------------------------------------- */
    ///
    /// PresenterBase
    ///
    /// <summary>
    /// View/Model/EventAggregator/Settings を持つ Presenter の基底となる
    /// クラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class PresenterBase<TView, TModel, TSettings>
        : PresenterBase<TView, TModel>
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="model">Model オブジェクト</param>
        /// <param name="settings">Settings オブジェクト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, TModel model, TSettings settings)
            : base(view, model)
        {
            Settings = settings;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="model">Model オブジェクト</param>
        /// <param name="settings">Settings オブジェクト</param>
        /// <param name="events">EventAggregator オブジェクト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, TModel model, TSettings settings, IEventAggregator events)
            : base(view, model, events)
        {
            Settings = settings;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// PresenterBase
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="view">View オブジェクト</param>
        /// <param name="model">Model オブジェクト</param>
        /// <param name="settings">Settings オブジェクト</param>
        /// <param name="events">EventAggregator オブジェクト</param>
        /// <param name="context">同期コンテキスト</param>
        /// 
        /* ----------------------------------------------------------------- */
        public PresenterBase(TView view, TModel model, TSettings settings,
            IEventAggregator events, SynchronizationContext context)
            : base(view, model, events, context)
        {
            Settings = settings;
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Settings
        /// 
        /// <summary>
        /// Settings オブジェクトを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public TSettings Settings { get; private set; }

        #endregion
    }

}
