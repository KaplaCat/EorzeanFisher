using EorzeanFisher.Utils;
using EorzeanFisher.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.ViewModel.User
{
    public class ProfilViewModel : ViewModelBase
    {
        string Id { get; set; }

        public ProfilViewModel()
        {
            Id = (string)DataHandler.getInstance().Data;
        }
    }
}
