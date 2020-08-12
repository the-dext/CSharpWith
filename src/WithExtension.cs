namespace CSharpWith
{
    using System;
    using System.Linq;

    public static class WithExtension
    {
        public static With<T> With<T>(this T arg) => new With<T>(arg);

        public static T With<T>(this T arg, params Action<T>[] actions)
        {
            return new With<T>(arg).Do(actions).EndWith;
        }
    }
}