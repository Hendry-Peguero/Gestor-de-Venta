
package configuracion;

/**
 *
 * @author Hendry
 */
public class Usuario {
    private String usuario;
    private String password;
    
    //Construtor
    public Usuario(){
        this.usuario = "";
        this.password = "";
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
    
}
