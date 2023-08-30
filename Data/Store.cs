namespace Chatty.Data
{
    public class State
    {
        public UserModel ActiveUser { get; set; } = new(new());
        public GroupLocker LockParameters { get; set; } = new("","","");
    }
    public class UserModel
    {
        public Users ActiveUser { get; }
        public UserModel(Users user)
        {
            ActiveUser = user;
        }
    }
    public class GroupLocker
    {
        public string GroupId { get; } = "";
        public string AdminId { get;} = "";
        public string GroupName { get; } = "";
        public GroupLocker(string groupId, string adminId, string groupName)
        {
            GroupId= groupId;
            AdminId= adminId;
            GroupName= groupName;
        }
    }
    public class Store : IStore
    {
        private State state = new();
        public State State()
        {
            return state;
        }


        public void AddUser(Users user)
        {
            state.ActiveUser = new UserModel(user);
            BroadcastChange();
        }
        public void AddGroupLockParameters(string groupId, string adminId, string groupName)
        {
            state.LockParameters = new GroupLocker(groupId, adminId, groupName);    
            BroadcastChange();
        }

        #region Observer Patterns
        private Action? action;

        public void AddStateChangedAction(Action? _action)
        {
            action += _action;
        }
        public void RemoveStateChangedAction(Action? _action)
        {
            action -= _action;
        }
        public void BroadcastChange()
        {
            action?.Invoke();
        }
        #endregion
    }
}
