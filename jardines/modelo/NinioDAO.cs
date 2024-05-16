using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jardines.modelo
{
    public class NinioDAO
    {
        ORMDataContext BD = new ORMDataContext();

        public void registrar(Ninos nino)
        {
            BD.Ninos.InsertOnSubmit(nino);
            BD.SubmitChanges(); // GUARDAR LOS CAMBIOS
        }

        public Object consultarTodos()
        {
            return from N in BD.Ninos
                   select N;
        }

        public Ninos consultarNinoId(int idNino)
        {
            return (from N in BD.Ninos
                    where N.idNino == idNino
                    select N).FirstOrDefault();
        }

        public void eliminar(int idNino)
        {
            Ninos ninoEliminar = consultarNinoId(idNino);
            BD.Ninos.DeleteOnSubmit(ninoEliminar);
            BD.SubmitChanges();
        }

        public void editar(Ninos nino)
        {
            Ninos ninoEditar = consultarNinoId(nino.idNino);
            ninoEditar.NUIP = nino.NUIP;
            ninoEditar.tipoSangre = nino.tipoSangre;
            ninoEditar.ciudadNacimiento = nino.ciudadNacimiento;
            ninoEditar.peso = nino.peso;
            ninoEditar.estatura = nino.estatura;
            ninoEditar.idJardin = nino.idJardin;
            ninoEditar.idAcudiente = nino.idAcudiente;
            ninoEditar.idDatosBasicos = nino.idDatosBasicos;
            ninoEditar.idEps = nino.idEps;
            BD.SubmitChanges();
        }
    }
}