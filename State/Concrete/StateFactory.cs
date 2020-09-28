using State.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Concrete
{
    class StateFactory
    {
        private Dictionary<string, LevelState> _dic = new Dictionary<string, LevelState>();
        public LevelState GetState<T>(Account account) where T: LevelState
        {
            var name = typeof(LevelState).Name;
            if (!_dic.TryGetValue(name, out LevelState accountState))
            {
                accountState = (LevelState)Activator.CreateInstance(typeof(T), account);
                _dic[name] = accountState;
            }
            accountState._account = account;
            return accountState;
        }
    }
}
