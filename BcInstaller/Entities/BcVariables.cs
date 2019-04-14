using System.Collections.Generic;

namespace BcInstaller.Entities
{
    public sealed class BcVariables
    {
        private readonly Dictionary<string, object> _variables;
        private readonly object _locker = new object();

        public BcVariables()
        {
            this._variables = new Dictionary<string, object>();
        }

        public object Get(string name, object @default = null)
        {
            lock (this._locker)
            {
                if (this._variables.ContainsKey(name))
                    return this._variables[name];
                return @default;
            }
        }

        public T Get<T>(string name, T @default = default(T))
        {
            lock (this._locker)
            {
                if (this._variables.ContainsKey(name))
                    return (T) this._variables[name];
                return @default;
            }
        }

        public void Set(string name, object value)
        {
            lock (this._locker)
            {
                if (this._variables.ContainsKey(name))
                    this._variables[name] = value;
                else
                    this._variables.Add(name, value);
            }
        }

        public void Set<T>(string name, T value)
        {
            lock (this._locker)
            {
                if (this._variables.ContainsKey(name))
                    this._variables[name] = value;
                else
                    this._variables.Add(name, value);
            }
        }

        public object Delete(string name)
        {
            lock (this._locker)
            {
                if (!this._variables.ContainsKey(name))
                    return null;

                var ret = this._variables[name];
                this._variables.Remove(name);
                return ret;
            }
        }

        public T Delete<T>(string name)
        {
            return (T)this.Delete(name);
        }
    }
}
