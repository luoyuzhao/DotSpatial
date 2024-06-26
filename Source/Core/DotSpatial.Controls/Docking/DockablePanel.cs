// Copyright (c) DotSpatial Team. All rights reserved.
// Licensed under the MIT license. See License.txt file in the project root for full license information.

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DotSpatial.Controls.Docking
{
    /// <summary>
    /// Named DockablePanel to avoid the name conflict with DockPanel in WPF and most control libraries.
    /// </summary>
    public class DockablePanel : INotifyPropertyChanged
    {
        #region Fields
        private string _caption;
        private short _defaultSortOrder;
        private DockStyle _dock;
        private Control _innerControl;
        private string _key;
        private Image _smallImage;
        #endregion

        #region  Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref = "DockablePanel" /> class.
        /// </summary>
        public DockablePanel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DockablePanel"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="innerControl">The inner control.</param>
        /// <param name="dock">The dock.</param>
        public DockablePanel(string key, string caption, Control innerControl, DockStyle dock)
        {
            Dock = dock;
            Key = key;
            InnerControl = innerControl;
            Caption = caption;
        }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the caption of the panel and any tab button.
        /// </summary>
        /// <value>The caption.</value>
        public string Caption
        {
            get
            {
                return _caption;
            }

            set
            {
                if (_caption == value)
                {
                    return;
                }

                _caption = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Caption)));
            }
        }

        /// <summary>
        /// Gets or sets the sort order. Lower values will suggest that an item should appear further left in a LeftToRight environment. Or higher up in a top to bottom environment.
        /// </summary>
        /// <remarks>Use a multiple of 100 or so to allow other developers some 'space' to place their panels.</remarks>
        /// <value>The sort order.</value>
        public short DefaultSortOrder
        {
            get
            {
                return _defaultSortOrder;
            }

            set
            {
                if (_defaultSortOrder == value)
                {
                    return;
                }

                _defaultSortOrder = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(DefaultSortOrder)));
            }
        }

        /// <summary>
        /// Gets or sets The dock location.
        /// </summary>
        /// <value>The dock location.</value>
        public DockStyle Dock
        {
            get
            {
                return _dock;
            }

            set
            {
                if (_dock == value)
                {
                    return;
                }

                _dock = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Dock)));
            }
        }

        /// <summary>
        /// Gets or sets the InnerControl.
        /// </summary>
        /// <value>The InnerControl.</value>
        public Control InnerControl
        {
            get
            {
                return _innerControl;
            }

            set
            {
                if (_innerControl == value)
                {
                    return;
                }

                _innerControl = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(InnerControl)));
            }
        }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The unique identifier.</value>
        public string Key
        {
            get
            {
                return _key;
            }

            set
            {
                if (_key == value)
                {
                    return;
                }

                _key = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Key)));
            }
        }

        /// <summary>
        /// Gets or sets the small image.
        /// </summary>
        /// <value>The small image.</value>
        public Image SmallImage
        {
            get
            {
                return _smallImage;
            }

            set
            {
                _smallImage = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SmallImage)));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Triggers the PropertyChanged event.
        /// </summary>
        /// <param name="ea">The event args.</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs ea)
        {
            PropertyChanged?.Invoke(this, ea);
        }

        #endregion
    }
}