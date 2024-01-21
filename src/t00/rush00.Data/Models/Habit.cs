using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using ReactiveUI;

namespace rush00.Data.Models
{
    
    public class Habit : ReactiveObject
    {
        [Key]
        public int Id { get; set; }
        
        private string _title;
        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        private string _motivation;
        public string Motivation
        {
            get => _motivation;
            set => this.RaiseAndSetIfChanged(ref _motivation, value);
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get => _startDate;
            set => this.RaiseAndSetIfChanged(ref _startDate, value);
        }

        private int _trackingDays;
        public int TrackingDays
        {
            get => _trackingDays;
            set => this.RaiseAndSetIfChanged(ref _trackingDays, value);
        }

        private ObservableCollection<HabitCheck> _progress;
        public ObservableCollection<HabitCheck> Progress
        {
            get => _progress;
            set => this.RaiseAndSetIfChanged(ref _progress, value);
        }

        private bool _isFinished;

        public bool IsFinished
        {
            get => _isFinished;
            set => this.RaiseAndSetIfChanged(ref _isFinished, value);
        }
        

        public Habit(string title, string motivation, DateTime startDate, int trackingDays)
        {
            _title = title;
            _motivation = motivation;
            _startDate = startDate;
            _trackingDays = trackingDays;
            _progress = new ObservableCollection<HabitCheck>();
            _isFinished = false;
        }
        
        public Habit(string title, string motivation, DateTime startDate, int trackingDays, ObservableCollection<HabitCheck> progress, bool isFinished)
        {
            _title = title;
            _motivation = motivation;
            _startDate = startDate;
            _trackingDays = trackingDays;
            _progress = progress ?? new ObservableCollection<HabitCheck>();
            _isFinished = isFinished;
        }
        
        public Habit(Habit existingHabit)
            : this(existingHabit.Title, existingHabit.Motivation, existingHabit.StartDate, existingHabit.TrackingDays, existingHabit.Progress, existingHabit.IsFinished)
        { }
    }
}