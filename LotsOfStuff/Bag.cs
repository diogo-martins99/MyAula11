using System;
using System.Collections.Generic;

namespace Aula11
{
    /// <summary>
    /// Classe que representa uma mochila ou saco que contem itens
    /// </summary>
    public class Bag : List<IStuff>, IStuff, IHasKarma
    {

        public float Karma
        {
            get
            {
                int itemsWithKarma = 0;
                float totalKarma = 0;
                foreach (IStuff aThing in this)
                {
                    if(aThing is IHasKarma)
                    {
                        itemsWithKarma++;
                        totalKarma += (aThing as IHasKarma).Karma;
                    }
                }
                return totalKarma;
            }
        }



        /// <summary> 
        /// Propriedade Weight respeita o contrato com IHasWeight. No caso do
        /// Bag o peso vai corresponder ao peso total dos itens.
        /// </summary>
        public float Weight
        {
            get
            {
                float totalWeight = 0;
                foreach (IStuff aThing in this)
                {
                    totalWeight += aThing.Weight;
                }
                return totalWeight;
            }
        }

        /// <summary> 
        /// Propriedade Value respeita o contrato com IValuable. No caso do
        /// Bag o valor vai corresponder ao valor total dos itens.
        /// </summary>
        public float Value
        {
            get
            {
                float totalValue = 0;
                foreach (IStuff aThing in this)
                {
                        totalValue += aThing.Value;
                }
                return totalValue;
            }
        }

        /// <summary>
        /// Construtor que cria uma nova instância de mochila
        /// </summary>
        /// <param name="bagSize">
        /// Número máximo de itens que é possível colocar na mochila
        /// </param>
        public Bag(int bagSize) : base(bagSize)
        {
        }

        /// <summary>
        /// Sobreposição do método ToString() para a classe Bag.
        /// </summary>
        /// <returns>
        /// Uma string contendo informação sobre a mochila e os seus conteúdos.
        /// </returns>
        public override string ToString()
        {
            return $"Mochila com {Count} itens e um peso e valor " +
                $"totais de {Weight:f2} Kg e {Value:f2} €, respetivamente";
        }
    }
}
