namespace State
{
    public abstract class HeroState
    {
        public abstract void Execute(Hero hero);
        
        public abstract void FixedExecute(Hero hero);

        public abstract void StartState(Hero hero);

        public abstract void EndState(Hero hero);
    }
}