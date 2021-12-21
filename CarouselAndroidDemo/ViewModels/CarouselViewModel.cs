using System;
using System.Collections.ObjectModel;

namespace CarouselAndroidDemo.ViewModels
{
    public class CarouselViewModel : BaseViewModel
    {
        private ObservableCollection<Element.CarouselCardViewModel> carouselItems;
        public ObservableCollection<Element.CarouselCardViewModel> CarouselItems
        {
            get => carouselItems;
            set
            {
                carouselItems = value;
                OnPropertyChanged(nameof(CarouselItems));
            }
        }
        public CarouselViewModel()
        {
            Title = "Browse";

            CarouselItems = new ObservableCollection<Element.CarouselCardViewModel>();
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        /// <summary>
        /// Clear data from the observable collections
        /// </summary>
        public void ClearData()
        {
            CarouselItems = new ObservableCollection<Element.CarouselCardViewModel>();
        }

    }
}