namespace CaloriasFarm.Utils.Files{

    public interface FileHandler{
        public object? ReadFile<T>(string File);
        public void WriteFile<T>(string File, T obj);
    }
}
