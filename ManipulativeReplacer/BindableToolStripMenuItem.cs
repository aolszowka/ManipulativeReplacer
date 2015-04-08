// -----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="Ace Olszowka">
// Copyright (c) Ace Olszowka 2015. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace ManipulativeReplacer
{
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// A wrapper around <see cref="ToolStripMenuItem"/> that supports binding.
    /// </summary>
    public class BindableToolStripMenuItem : ToolStripMenuItem, IBindableComponent
    {
        private BindingContext bindingContext;
        private ControlBindingsCollection dataBindings;

        /// <summary>
        /// Gets or sets the collection of currency managers for the <see cref="System.Windows.Forms.IBindableComponent"/>.
        /// </summary>
        [Browsable(false)]
        public BindingContext BindingContext
        {
            get
            {
                if (this.bindingContext == null)
                {
                    this.bindingContext = new BindingContext();
                }

                return this.bindingContext;
            }
            set
            {
                this.bindingContext = value;
            }
        }

        /// <summary>
        /// Gets the collection of data-binding objects for this <see cref="System.Windows.Forms.IBindableComponent."/>
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ControlBindingsCollection DataBindings
        {
            get
            {
                if (this.dataBindings == null)
                {
                    this.dataBindings = new ControlBindingsCollection(this);
                }

                return this.dataBindings;
            }
        }

    }
}
