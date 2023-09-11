namespace Chokomaka.UIs.Views
{
    public interface IView<T>
    {
        void SetCurrent(T t);
    }
}