public class Client
{
        public void ClientMethod(IDetectEffect factory, Item item, Enemy enemy)
        {
                var detect = factory.GetEffect(item.damage,item.time);
                detect.Executed(enemy);
        }
}