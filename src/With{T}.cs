namespace CSharpWith
{
    using System;

    public class With<T>
    {
        private readonly T Arg;

        public With(T arg)
        {
            this.Arg = arg;
        }

        public With<T> Do(Action<T> action)
        {
            action(this.Arg);

            return this;
        }

        public With<T> Do(params Action<T>[] actions)
        {
            foreach (var action in actions)
            {
                action(this.Arg);
            }
            return this;
        }

        public T EndWith { get => this.Arg; }
    }
}