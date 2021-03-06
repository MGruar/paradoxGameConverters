﻿using Caliburn.Micro;
using Frontend.Core.Model.Interfaces;

namespace Frontend.Core.Model
{
    public class ConverterOptions : PropertyChangedBase, IConverterOptions
    {
        private IConverterSettings currentConverter;

        /// <summary>
        ///     Gets or sets a value indicating whether conversion was successful.
        /// </summary>
        /// <value>
        ///     <c>true</c> if conversion was successful; otherwise, <c>false</c>.
        /// </value>
        public bool WasConversionSuccessful { get; set; }

        /// <summary>
        ///     Gets or sets the current converter settings
        /// </summary>
        public IConverterSettings CurrentConverter
        {
            get { return currentConverter; }

            set
            {
                if (currentConverter == value)
                {
                    return;
                }

                Reset(value);
                currentConverter = value;
                NotifyOfPropertyChange(() => CurrentConverter);
            }
        }

        public void Reset(IConverterSettings newSettings)
        {
        }
    }
}