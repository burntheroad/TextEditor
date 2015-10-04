﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    /// <summary>
    /// Interface provides basic functionality for reading text from file.
    /// </summary>
    public interface IFileReader
    {
        /// <summary>
        /// Gets or sets the path to file.
        /// </summary>
        /// <value>The FileName property gets/sets the value of the string field, filename.</value>
        string FileName { get; set; }

        /// <summary>
        /// Reads data from file.
        /// </summary>
        /// <returns>Array of read strings.</returns>
        string[] ReadFile();
    }
}
