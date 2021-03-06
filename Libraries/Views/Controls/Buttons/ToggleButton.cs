﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
using System.ComponentModel;
using System.Drawing;
using Cube.Forms.Controls;

namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// ToggleButton
    /// 
    /// <summary>
    /// トグルボタンを作成するためのクラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class ToggleButton : System.Windows.Forms.CheckBox, IControl
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// ToggleButton
        ///
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public ToggleButton() : base()
        {
            _painter = new ToggleButtonPainter(this);
            _painter.Styles.PropertyChanged += (s, e) => Invalidate();
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// EventHub
        /// 
        /// <summary>
        /// イベントを集約するためのオブジェクトを取得または設定します。
        /// </summary>
        /// 
        /// <remarks>
        /// Controls に登録されている IControl オブジェクトに対して、
        /// 再帰的に設定します。
        /// </remarks>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IEventHub EventHub
        {
            get => _events;
            set
            {
                if (_events == value) return;
                _events = value;
                foreach (var obj in Controls)
                {
                    if (obj is IControl c) c.EventHub = value;
                }
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Dpi
        /// 
        /// <summary>
        /// 現在の Dpi の値を取得または設定します。
        /// </summary>
        /// 
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Dpi
        {
            get => _dpi;
            set
            {
                if (_dpi == value) return;
                var old = _dpi;
                _dpi = value;
                OnDpiChanged(ValueChangedEventArgs.Create(old, value));
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Styles
        ///
        /// <summary>
        /// ボタンの外観を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ButtonStyleContainer Styles => _painter.Styles;

        /* ----------------------------------------------------------------- */
        ///
        /// Content
        ///
        /// <summary>
        /// ボタンに表示する内容を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(true)]
        public string Content
        {
            get => _painter.Content;
            set
            {
                if (_painter.Content == value) return;
                _painter.Content = value;
                Invalidate();
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ShowFocusCues
        /// 
        /// <summary>
        /// フォーカス時に枠線を描画するかどうかを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected override bool ShowFocusCues => false;

        #region Hiding properties

        #region ButtonBase

        /* ----------------------------------------------------------------- */
        ///
        /// BackColor
        /// 
        /// <summary>
        /// 背景色を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// BackColor
        /// 
        /// <summary>
        /// 背景イメージを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Image BackgroundImage
        {
            get => base.BackgroundImage;
            set => base.BackgroundImage = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// FlatAppearance
        /// 
        /// <summary>
        /// 表示内容を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new System.Windows.Forms.FlatButtonAppearance FlatAppearance
            => base.FlatAppearance;

        /* ----------------------------------------------------------------- */
        ///
        /// FlatStyle
        /// 
        /// <summary>
        /// 表示方法を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new System.Windows.Forms.FlatStyle FlatStyle
        {
            get => base.FlatStyle;
            set => base.FlatStyle = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ForeColor
        /// 
        /// <summary>
        /// 前景色を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Image
        /// 
        /// <summary>
        /// 表示イメージを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new Image Image
        {
            get => base.Image;
            set => base.Image = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ImageIndex
        /// 
        /// <summary>
        /// イメージを取得するためのインデックスを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new int ImageIndex
        {
            get => base.ImageIndex;
            set => base.ImageIndex = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ImageKey
        /// 
        /// <summary>
        /// イメージを取得するためのキーを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string ImageKey
        {
            get => base.ImageKey;
            set => base.ImageKey = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// ImageList
        /// 
        /// <summary>
        /// イメージリストを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new System.Windows.Forms.ImageList ImageList
        {
            get => base.ImageList;
            set => base.ImageList = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Text
        /// 
        /// <summary>
        /// 表示テキストを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// TextImageRelation
        /// 
        /// <summary>
        /// テキストとイメージの位置関係を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new System.Windows.Forms.TextImageRelation TextImageRelation
        {
            get => base.TextImageRelation;
            set => base.TextImageRelation = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// UseVisualStyleBakColor
        /// 
        /// <summary>
        /// VisualStyle を適用するかどうかを示す値を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new bool UseVisualStyleBackColor
        {
            get => base.UseVisualStyleBackColor;
            set => base.UseVisualStyleBackColor = value;
        }

        #endregion

        #region CheckBox

        /* ----------------------------------------------------------------- */
        ///
        /// Appearance
        /// 
        /// <summary>
        /// 表示方法を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        public new System.Windows.Forms.Appearance Appearance
        {
            get => base.Appearance;
            set => base.Appearance = value;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// CheckAlign
        /// 
        /// <summary>
        /// チェックボックスの表示位置を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        [Browsable(false)]
        public new ContentAlignment CheckAlign
        {
            get => base.CheckAlign;
            set => base.CheckAlign = value;
        }

        #endregion

        #endregion

        #endregion

        #region Events

        #region DpiChanged

        /* ----------------------------------------------------------------- */
        ///
        /// DpiChanged
        ///
        /// <summary>
        /// DPI の値が変化した時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event ValueChangedEventHandler<double> DpiChanged;

        /* ----------------------------------------------------------------- */
        ///
        /// OnDpiChanged
        ///
        /// <summary>
        /// DpiChanged イベントを発生させます。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected virtual void OnDpiChanged(ValueChangedEventArgs<double> e)
        {
            this.UpdateControl(e.OldValue, e.NewValue);
            DpiChanged?.Invoke(this, e);
        }

        #endregion

        #region NcHitTest

        /* ----------------------------------------------------------------- */
        ///
        /// NcHitTest
        ///
        /// <summary>
        /// マウスのヒットテスト時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event QueryEventHandler<Point, Position> NcHitTest;

        /* ----------------------------------------------------------------- */
        ///
        /// OnNcHitTest
        ///
        /// <summary>
        /// NcHitTest イベントを発生させます。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected virtual void OnNcHitTest(QueryEventArgs<Point, Position> e)
            => NcHitTest?.Invoke(this, e);

        #endregion

        #endregion

        #region Fields
        private ButtonPainter _painter = null;
        private IEventHub _events;
        private double _dpi = StandardForm.BaseDpi;
        #endregion
    }
}
