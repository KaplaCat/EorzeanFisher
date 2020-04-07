using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EorzeanFisher.ViewModel.Base
{
    public interface IHandleViewAppearing
    {
        Task OnViewAppearingAsync(VisualElement view);
    }

    public interface IHandleViewDisappearing
    {
        Task OnViewDisappearingAsync(VisualElement view);
    }
}
