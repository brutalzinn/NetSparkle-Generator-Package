﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NetSparkleUpdater.Interfaces
{
    /// <summary>
    /// Interface used by objects that can download app casts from the internet.
    /// Use this interface to provide a custom method of grabbing your app cast
    /// from the internet or from a local file.
    /// </summary>
    public interface IAppCastDataDownloader
    {
        /// <summary>
        /// Used for both downloading app cast and the app cast's .dsa file.
        /// Note that you must handle your own exceptions if they occur. Otherwise, SparkleUpdater
        /// will act as though the appcast failed to download.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        string DownloadAndGetAppCastData(string url);

        /// <summary>
        /// Get the string encoding (e.g. UTF8 or ASCII) of the 
        /// app cast file so that it can be converted to bytes.
        /// (WebRequestAppCastDataDownloader defaults to UTF8.)
        /// </summary>
        /// <returns></returns>
        Encoding GetAppCastEncoding();
    }
}
