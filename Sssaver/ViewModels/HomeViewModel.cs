using System;
using System.Collections.ObjectModel;
using Sssaver.Models;

namespace Sssaver.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public SavingsPlan SavingsPlan { get; set; }

        public decimal TodaysSavingsAmount { get; set; }
        
        public ObservableCollection<SavingsChallenge> SavingsHistory { get; set; }

        public HomeViewModel(SavingsPlan savingsPlan = null)    
        {
            if (savingsPlan == null)
            {
                // if no savingsPlan is passed into the constructor,
                // then create one. This is for demo purposes.
                SavingsPlan = new SavingsPlan()
                {
                    Days = 15,
                    StartDate = new DateTime(2021, 12, 1),
                    EndDate = new DateTime(2022, 1, 1),
                    Name = "Viper",
                    CurrentSavingsAmount = 1050,
                    TotalSavingsAmount = 4960,
                    GoalImage = "toyotacamry.jpg",
                    SavingsChallenges =
                    {
                        
                    }
                };

                // Today's Savings Amount should be extracted from
                // the SavingsChallenges list in the SavingsPlan.


                // The SavingsHistory should be loaded from the
                // SavingsChallenges list in the SavingsPlan.

                //biggest struggle is implementing history Utilize the observable collection of savings challenge objects. Make the Savingsplan an observable collection of savings plans
            }
        }
    }
}
