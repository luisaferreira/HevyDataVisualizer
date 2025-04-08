using CsvHelper.Configuration;
using HevyDataVisualizer.Models;

namespace HevyDataVisualizer.Mappings;

public class WorkoutMap : ClassMap<Workout>
{
    public WorkoutMap()
    {
        Map(m => m.Title).Name("title");
        Map(m => m.StartTime).Name("start_time");
        Map(m => m.EndTime).Name("end_time");
        Map(m => m.Description).Name("description");
        Map(m => m.ExerciseTitle).Name("exercise_title");
        Map(m => m.SupersetId).Name("superset_id");
        Map(m => m.ExerciseNotes).Name("exercise_notes");
        Map(m => m.SetIndex).Name("set_index");
        Map(m => m.SetType).Name("set_type");
        Map(m => m.WeightKg).Name("weight_kg");
        Map(m => m.Reps).Name("reps");
        Map(m => m.DistanceKm).Name("distance_km");
        Map(m => m.DurationSeconds).Name("duration_seconds");
        Map(m => m.Rpe).Name("rpe");
    }
}
