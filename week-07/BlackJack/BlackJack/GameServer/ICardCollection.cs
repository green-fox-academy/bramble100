namespace BlackJack.GameServer
{
    public interface ICardCollection
    {
        string GetCardsList();
        Card PullFirst();
        Card PullLast();
        Card PullRandom();
        void Shuffle();
        string ToString();
    }
}