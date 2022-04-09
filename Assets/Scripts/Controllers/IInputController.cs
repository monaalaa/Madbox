namespace Controllers
{
    public interface IInputController
    {
        bool StartMove();
        bool Moving();
        bool EndMove();
        bool Attack();
    }
}
