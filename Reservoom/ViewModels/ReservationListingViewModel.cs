using Reservoom.Commands;
using Reservoom.Models;
using Reservoom.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservoom.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(NavigationStore navigationStore, Func<MakeReservationViewModel> createMakeReservationViewModel)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            MakeReservationCommand = new NavigateCommand(navigationStore, createMakeReservationViewModel);

            _reservations.Add(new ReservationViewModel(new Reservation(
                new RoomID(3, 1),
                "Gnevilkoko",
                DateTime.Now,
                DateTime.Now)));

            _reservations.Add(new ReservationViewModel(new Reservation(
                new RoomID(1, 2),
                "Gnevilkoko",
                DateTime.Now,
                DateTime.Now)));

            _reservations.Add(new ReservationViewModel(new Reservation(
                new RoomID(1, 1),
                "Gnevilkoko",
                DateTime.Now,
                DateTime.Now)));
        }
    }
}
