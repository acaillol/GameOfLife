using System.Collections.Generic;

namespace GameOfLife
{
    public class JeuDeLaVie
    {
        private const char CELLULE_MORTE = '.';
        private const char CELLULE_VIVANTE = '*';
        List<List<char>> universOrigine;

        public JeuDeLaVie(List<List<char>> universEntree)
        {
            universOrigine = universEntree;
        }

        public List<List<char>> JouerEtapeSuivante()
        {
            List<List<char>> universSortie = universOrigine;
            for (int i = 0; i < universOrigine.Count; i++)
            {
                var ligneCellules = universOrigine[i];

                for (int j = 0; j < ligneCellules.Count; j++)
                {
                    if (EstVivante(ligneCellules[j]))
                    {
                        if (!(EstVivante(ligneCellules[j - 1]) && EstVivante(ligneCellules[j + 1])))
                            ligneCellules[j] = CELLULE_MORTE;
                    }
                }
            }

            return universOrigine;
        }

        private bool EstVivante(char cellule)
        {
            return cellule == CELLULE_VIVANTE;
        }
    }
}
