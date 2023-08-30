namespace Chatty.Data
{
    public interface IStore
    {
        void AddStateChangedAction(Action? _action);
        void AddUser(Users user);
        void BroadcastChange();
        void RemoveStateChangedAction(Action? _action);
        void AddGroupLockParameters(string groupId, string adminId, string groupName);
        State State();
    }
}