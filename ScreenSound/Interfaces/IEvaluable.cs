
using ScreenSound.Models;

namespace ScreenSound.Interfaces;

internal interface IEvaluable
{
    void AddNote(Rating note);
    public double Avarage { get; }


}
