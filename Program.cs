var vista = new Maxiflo.UI.Consola.Vista();
var sistema = new Maxiflo.Sistema();
var controlador = new Maxiflo.UI.Consola.Controlador(vista, sistema);
controlador.Run();