﻿using System;
using System.IO;
using System.Collections.Generic;

namespace Sandcastle.ReflectionData
{
    /// <summary>
    /// This provides a set of static methods for handling common errors in the 
    /// documentation process.
    /// </summary>
    internal static class BuildExceptions
    {                           
        public static void NotNull(object argObject, string argName)
        {   
            if (argObject == null)
            {
                throw new ArgumentNullException(argName, String.Format(
                    "The parameter '{0}' is required, and cannot be null (or Nothing).", argName));
            }
        }

        public static void NotNull(string argObject, string argName)
        {
            if (argObject == null)
            {
                throw new ArgumentNullException(argName, String.Format(
                    "The parameter '{0}' is required, and cannot be null (or Nothing).", argName));
            }
        }

        public static void NotEmpty(string argObject, string argName)
        {
            if (String.IsNullOrEmpty(argObject))
            {
                throw new ArgumentException(String.Format(
                    "The parameter '{0}' is required, and cannot be empty.", argName), argName);
            }
        }

        public static void NotNullNotEmpty(string argObject, string argName)
        {
            if (argObject == null)
            {
                throw new ArgumentNullException(argName, String.Format(
                    "The parameter '{0}' is required, and cannot be null (or Nothing).", argName));
            }
            if (argObject.Length == 0)
            {
                throw new ArgumentException(String.Format(
                    "The parameter '{0}' is required, and cannot be empty.", argName), argName);
            }
        }

        public static void NotNullNotEmpty<T>(IList<T> argObject, string argName)
        {
            if (argObject == null)
            {
                throw new ArgumentNullException(argName, String.Format(
                    "The parameter '{0}' is required, and cannot be null (or Nothing).", argName));
            }
            if (argObject.Count == 0)
            {
                throw new ArgumentException(String.Format(
                    "The parameter '{0}' is required, and cannot be empty.", argName), argName);
            }
        }

        public static void PathMustExist(string argObject, string argName)
        {
            if (argObject == null)
            {
                throw new ArgumentNullException(argName,
                    String.Format("The file path '{0}' cannot be null (or Nothing).",
                    argName));
            }
            if (argObject.Length == 0)
            {
                throw new ArgumentException("The file path is not valid.", argName);
            }
            if (File.Exists(argObject) == false)
            {
                throw new ArgumentException("The file path must exists.", argName);
            }
        }
    }
}
