using CarouselAndroidDemo.ViewModels;
using System;
using Xamarin.Forms;

namespace CarouselAndroidDemo.Views
{
    public partial class CarouselPage : ContentPage
    {
        private readonly CarouselViewModel viewModel;

        public CarouselPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CarouselViewModel();

            CreateCarousel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.OnAppearing();

            CreateCarousel();
        }


        /// <summary>
        /// Create / Rebuild the carousel
        /// </summary>
        protected void CreateCarousel()
        {

            ClearCarousel();

            int numberOfItems = 3;

            for (int i = 0; i < numberOfItems; i++)
            {
                ViewModels.Element.CarouselCardViewModel carouselCard = new ViewModels.Element.CarouselCardViewModel();

                carouselCard.CarouselIndex = i;
                carouselCard.Image.Source = ImageSource.FromUri(new Uri("https://lilalu-shop.com/media/image/35/9c/a5/lilalu-quietscheente-gelb-yellow-rubber-duck-HL.png"));

                ((CarouselViewModel)BindingContext).CarouselItems.Add(carouselCard);
            }
        }

        /// <summary>
        /// Delete all elements from the carousel
        /// </summary>
        protected void ClearCarousel()
        {
            ((CarouselViewModel)BindingContext).ClearData();
        }
    }
}