
package configuracion;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author Hendry
 */
public class ConexionDB {
       Connection cn;
    
    public Connection conectar(){
        try{
            Class.forName("com.mysql.cj.jdbc.Driver");
            cn = (Connection) DriverManager.getConnection("jdbc:mysql://localhost/ProyectoFinal", "root", "");
            System.out.println("Estamos conectados con exito.");
            
        }catch(ClassNotFoundException | SQLException ex){
            System.out.println("Error en la conexion :" + ex);
        }
        return cn;
    }
    
}
