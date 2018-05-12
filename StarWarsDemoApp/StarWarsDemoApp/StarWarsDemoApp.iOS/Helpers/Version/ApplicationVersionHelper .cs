// <copyright file="ApplicationVersionHelper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StarWarsDemoApp.iOS.Helpers.Version
{
    using Foundation;
    using StarWarsDemoApp.Helpers.Version;

    public class ApplicationVersionHelper : IApplicationVersionHelper
    {
        private const string VersionKey = "CFBundleShortVersionString";

        public string GetApplicationVersion()
        {
            NSObject version = NSBundle.MainBundle.InfoDictionary[VersionKey];

            return version.ToString();
        }
    }
}