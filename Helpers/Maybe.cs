using System;

namespace AutomatedFlow.Helpers
{
    public abstract class Maybe<T>
    {
        public abstract Maybe<TResult> Bind<TResult>(Func<T, Maybe<TResult>> func);
        public abstract T GetValueOrDefault(T defaultValue);

        public static Maybe<T> Some(T value) => new Some<T>(value);
        public static Maybe<T> None() => new None<T>();
    }

    public class Some<T> : Maybe<T>
    {
        private readonly T _value;

        public Some(T value)
        {
            _value = value;
        }

        public override Maybe<TResult> Bind<TResult>(Func<T, Maybe<TResult>> func)
        {
            return func(_value);
        }

        public override T GetValueOrDefault(T defaultValue)
        {
            return _value;
        }
    }

    public class None<T> : Maybe<T>
    {
        public override Maybe<TResult> Bind<TResult>(Func<T, Maybe<TResult>> func)
        {
            return new None<TResult>();
        }

        public override T GetValueOrDefault(T defaultValue)
        {
            return defaultValue;
        }
    }

    public static class MaybeExtensions
    {
        public static Maybe<T> ToMaybe<T>(this T value)
        {
            return value == null ? Maybe<T>.None() : Maybe<T>.Some(value);
        }

        public static Maybe<T?> ToMaybe<T>(this T? value) where T : struct
        {
            return value.HasValue ? Maybe<T?>.Some(value) : Maybe<T?>.None();
        }
    }
}
