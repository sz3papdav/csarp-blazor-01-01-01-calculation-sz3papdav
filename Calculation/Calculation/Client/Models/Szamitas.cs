using System;
using System.ComponentModel;
using ViewModels.BaseClass;

namespace Calculation.Client.Models
{
    public class Szamit : ViewModelBase
    {
        public double _egyikszam;
        public double _masikszam;

        public Szamit()
        {
            _egyikszam = 0;
            _masikszam = 0;
        }
        public string Egyikszam
        {
            get => _egyikszam.ToString();
            set => SetValue(ref _egyikszam, Convert.ToDouble(value));
        }
        public string Masikszam
        {
            get => _masikszam.ToString();
            set => SetValue(ref _masikszam, Convert.ToDouble(value));
        }

        public double EredmenySzamitas
        {
            get
            {
                double ertek = _egyikszam * _masikszam;
                return ertek;
            }
        }
        public string Eredmeny
        {
            get
            {
                return "A 2 szám szorzata: " + EredmenySzamitas;
            }
        }
        public void Compute()
        {
            OnPropertyChanged(nameof(EredmenySzamitas));
            OnPropertyChanged(nameof(Eredmeny));
        }
    }
}
