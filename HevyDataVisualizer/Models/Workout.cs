namespace HevyDataVisualizer.Models;

public class Workout
{
    public string Title { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Description { get; set; }
    public string ExerciseTitle { get; set; }
    public string SupersetId { get; set; } //TODO: Verify the utility of this
    public string ExerciseNotes { get; set; }
    public int SetIndex { get; set; }
    public string SetType { get; set; }
    public int WeightKg { get; set; }
    public int Reps { get; set; }
    public int DistanceKm { get; set; }
    public int DurationSeconds { get; set; }
    public int Rpe { get; set; }
}
