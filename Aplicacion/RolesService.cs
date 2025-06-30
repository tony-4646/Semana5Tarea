using System.Collections.Generic;

namespace Semana5Tarea.Aplicacion
{
    public class RolesService
    {
        private AccesoDatos.RolesDAO _rolesDAO = new AccesoDatos.RolesDAO();
        public List<Datos.RolesDTO> todos()
        {
            return _rolesDAO.todos();
        }

        public string insertar(Datos.RolesDTO rolesDTO)
        {
            return _rolesDAO.insertar(rolesDTO);
        }

        public string actualizar(Datos.RolesDTO rolesDTO)
        {
            return _rolesDAO.actualizar(rolesDTO);
        }

        public string eliminar (int RolesId)
        {
            return _rolesDAO.eliminar(RolesId);
        }
    }
}
