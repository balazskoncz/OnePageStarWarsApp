// <copyright file="MainViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace StarWarsDemoApp.ViewModels
{
    using System.Windows.Input;
    using StarWarsDemoApp.Models;
    using Xamarin.Forms;

    public class MainViewModel
    {
        public MainViewModel()
        {
            this.Model = new MainModel();

            this.PlanetsCommand = new Command(this.ExecutePlanetsCommand);
            this.StarShipsCommand = new Command(this.ExecuteStarShipsCommand);
            this.PeopleCommand = new Command(this.ExecutePeopleCommand);
        }

        public MainModel Model
        {
            get; set;
        }

        public ICommand PlanetsCommand { get; set; }

        public ICommand StarShipsCommand { get; set; }

        public ICommand PeopleCommand { get; set; }

        private void ExecutePlanetsCommand()
        {
            // Navigate to Movies page
        }

        private void ExecuteStarShipsCommand()
        {
            // Navigate to Series page
        }

        private void ExecutePeopleCommand()
        {
            // Navigate to People page
        }
    }

}
