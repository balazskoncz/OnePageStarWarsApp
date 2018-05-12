// <copyright file="MainModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace StarWarsDemoApp.Models
{
    using StarWarsDemoApp.Helpers.Version;
    using StarWarsDemoApp.Models.Base;
    using Xamarin.Forms;

    public class MainModel : ObservableObject
    {
        private readonly IApplicationVersionHelper versionHelper;

        public MainModel()
        {
            this.versionHelper = DependencyService.Get<IApplicationVersionHelper>();
        }

        public string Version
        {
            get
            {
                return this.versionHelper.GetApplicationVersion();
            }
        }
    }
}
