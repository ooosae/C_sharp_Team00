using ReactiveUI;
using System.ComponentModel.DataAnnotations;

namespace rush00.Data.Models;

public class HabitCheck : ReactiveObject
{
    [Key]
    public int Id { get; set; }
    
    private DateTime _date;
    public DateTime Date
    {
        get => _date;
        set => this.RaiseAndSetIfChanged(ref _date, value);
    }

    private bool _isChecked;
    public bool IsChecked
    {
        get => _isChecked;
        set => this.RaiseAndSetIfChanged(ref _isChecked, value);
    }
    
    public HabitCheck(DateTime date, bool isChecked)
    {
        _date = date;
        _isChecked = isChecked;
    }
}
