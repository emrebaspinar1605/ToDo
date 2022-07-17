using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Cards
    {
        private List<CardModel> cards;
        
        public Cards()
        {
            cards = new List<CardModel>();
        }

        public List<CardModel> List()
        {
            return cards;
        }

        public void Add(string header,string content,string appointedPerson,string grown)
        {
            CardModel model=new CardModel();
            model.Header=header;
            model.Content=content;
            model.AppointedPerson=appointedPerson;
            model.Grown=grown;
            cards.Add(model);
        }
        public void Delete(CardModel cardModel)
        {
            cards.Remove(cardModel);
        }

        public List<CardModel> Find(string header,string appointedPerson,string content,string grown)
        {
            
            List<CardModel> result = new List<CardModel>();
            foreach (var card in cards)
            {
                if (card.Header == header || card.Content == content || card.Grown == grown || card.AppointedPerson == appointedPerson)
                {  
                    result.Add(card);
                }
            }
            return result;
        }
    }
}