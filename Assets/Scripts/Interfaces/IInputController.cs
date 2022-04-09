namespace Interfaces
{
    public interface IInputController
    {
        bool StartMove();
        bool Moving();
        bool EndMove();
        bool Attack();
    }
}
