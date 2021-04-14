using System;
namespace MotorMeans.ViewModels
{
    public class VolumeModel : BaseViewModel
    {
        public VolumeModel()
        {
        }

        private decimal liters = 0.0m;
        public decimal Liters
        {
            get
            {
                return liters;
            }
            set
            {
                if (liters != value)
                {
                    liters = value;
                    OnPropertyChanged(nameof(Liters));
                    OnPropertyChanged(nameof(CubicInches));
                }
            }
        }

        private decimal cubicInches = 0.0m;
        public decimal CubicInches
        {
            get
            {
                return cubicInches;
            }
            set
            {
                if (cubicInches != value)
                {
                    cubicInches = value;
                    OnPropertyChanged(nameof(Liters));
                    OnPropertyChanged(nameof(CubicInches));
                }
            }
        }
    }
}
