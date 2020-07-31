using System.Collections.ObjectModel;

namespace UwpDemo
{
    public class LigaLista : ObservableCollection<Liga>
    {
        public LigaLista()
        {
            Liga l;
            Division d;

            Add(l = new Liga("Liga Inglesa"));
            l.Divisiones.Add((d = new Division("Premier League")));
            d.Equipos.Add(new Equipo("Manchester United"));
            d.Equipos.Add(new Equipo("Liverpool"));
            d.Equipos.Add(new Equipo("Chelsea"));
            d.Equipos.Add(new Equipo("Manchester City"));
            d.Equipos.Add(new Equipo("Arsenal"));
            l.Divisiones.Add((d = new Division("EFL Championship")));
            d.Equipos.Add(new Equipo("Cardiff City"));
            d.Equipos.Add(new Equipo("Nottingham Forest"));
            d.Equipos.Add(new Equipo("Derby County"));
            d.Equipos.Add(new Equipo("Swansea City"));
            d.Equipos.Add(new Equipo("Queens Park Rangers"));
            l.Divisiones.Add((d = new Division("EFL League One")));
            d.Equipos.Add(new Equipo("Gillingham"));
            d.Equipos.Add(new Equipo("Ipswich Town"));
            d.Equipos.Add(new Equipo("Blackpool"));
            d.Equipos.Add(new Equipo("Rochdale"));
            Add(l = new Liga("Liga Italiana"));
            l.Divisiones.Add((d = new Division("Serie A")));
            d.Equipos.Add(new Equipo("Juventus"));
            d.Equipos.Add(new Equipo("AC Milan"));
            d.Equipos.Add(new Equipo("Inter"));
            d.Equipos.Add(new Equipo("Roma"));
            d.Equipos.Add(new Equipo("Lazio"));
            l.Divisiones.Add((d = new Division("Serie B")));
            d.Equipos.Add(new Equipo("Salernitana"));
            d.Equipos.Add(new Equipo("Empoli"));
            d.Equipos.Add(new Equipo("Pescara"));
            d.Equipos.Add(new Equipo("Ascoli"));
            l.Divisiones.Add((d = new Division("Serie C")));
            d.Equipos.Add(new Equipo("Arezzo"));
            d.Equipos.Add(new Equipo("Novara"));
            d.Equipos.Add(new Equipo("Siena"));
            d.Equipos.Add(new Equipo("Pianese"));
            d.Equipos.Add(new Equipo("Como"));
        }
    }
}
