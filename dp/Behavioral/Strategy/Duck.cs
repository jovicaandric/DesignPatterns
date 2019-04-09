namespace dp.Behavioral.Strategy
{
    // Instead of having multiple classes that inherit Duck, we have only one Duck but we inject different behaviors
    public class Duck
    {
        IFlyBehavior fb;
        IQuackBehavior qb;
        IDisplayBehavior db;

        public Duck(IFlyBehavior fb, IQuackBehavior qb, IDisplayBehavior db)
        {
            this.fb = fb;
            this.qb = qb;
            this.db = db;
        }

        public void fly(){
            fb.fly();
        }

        public void display(){
            db.display();
        }

        public void quack(){
            qb.quack();
        }
    }
}