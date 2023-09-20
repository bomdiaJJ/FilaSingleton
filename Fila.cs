public class Fila {

	private Fila _instance;

	private Fila() {}

	public void ImprimeDocumento() {}

	public void RemoveDocumento() {}

	public void RemoveTodosDocumentos() {}

	public Fila Instance {
		get {
			if (_instance == null)
				_instance = new Fila();

			return _instance;
		}
	}

}