using Xamarin.Forms;

namespace CarouselAndroidDemo.ViewModels.Element
{
    public class CarouselCardViewModel : BaseViewModel
    {
        public int CarouselIndex { get; set; } = 0;

        public Image Image { get; set; } = new Image();
    }
}