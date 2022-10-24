using Microsoft.EntityFrameworkCore;
namespace webapidb.Models{

    class conexion : DbContext{

        public Conexion(DbContextOptions<Conexion> options) : base (options){}
        public Dbset<Clientes>Clientes{get;set}
    }

    class conectar {
        private const cadenaConexion="server=localhost;port=3306;database=dbEmpresa;userid=user;pwd=valerie1";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.options);
            return cn;
        }


    }


}