package vista;

import configuracion.Producto;
import com.mysql.cj.jdbc.CallableStatement;
import configuracion.ConexionDB;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.ResultSet;
import java.sql.Statement;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;
import java.util.Optional;

/**
 *
 * @author Hendry
 */
public class jp2 extends javax.swing.JPanel {

    ConexionDB con = new ConexionDB();
    java.sql.Connection cn = con.conectar();

    /**
     * Creates new form jp2
     */
    public jp2() {
        initComponents();
        mostrardatos();
        cargarproductos();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jp2 = new javax.swing.JPanel();
        jPanel4 = new javax.swing.JPanel();
        jLabel19 = new javax.swing.JLabel();
        jLabel20 = new javax.swing.JLabel();
        jboxproductos = new javax.swing.JComboBox<>();
        jButton3 = new javax.swing.JButton();
        jButton13 = new javax.swing.JButton();
        txtcantidad = new javax.swing.JTextField();
        jLabel24 = new javax.swing.JLabel();
        txtprecio = new javax.swing.JTextField();
        jLabel26 = new javax.swing.JLabel();
        btnventas = new javax.swing.JButton();
        txtfecha = new com.toedter.calendar.JDateChooser();
        jScrollPane2 = new javax.swing.JScrollPane();
        jtabla = new javax.swing.JTable();

        jp2.setBackground(new java.awt.Color(229, 228, 228));
        jp2.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Ventas", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.DEFAULT_POSITION, new java.awt.Font("Segoe UI", 0, 18))); // NOI18N

        jPanel4.setBackground(new java.awt.Color(204, 204, 204));
        jPanel4.setBorder(javax.swing.BorderFactory.createTitledBorder("Producto"));

        jLabel19.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel19.setText("Producto");

        jLabel20.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel20.setText("Cantidad");

        jboxproductos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jboxproductosActionPerformed(evt);
            }
        });

        jButton3.setText("Agregar");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });

        jButton13.setText("Eliminar");
        jButton13.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton13ActionPerformed(evt);
            }
        });

        txtcantidad.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtcantidadActionPerformed(evt);
            }
        });

        jLabel24.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel24.setText("Fecha");

        txtprecio.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtprecioActionPerformed(evt);
            }
        });

        jLabel26.setFont(new java.awt.Font("Segoe UI", 0, 14)); // NOI18N
        jLabel26.setText("Precio");

        btnventas.setText("registrar venta");
        btnventas.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnventasActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel4Layout = new javax.swing.GroupLayout(jPanel4);
        jPanel4.setLayout(jPanel4Layout);
        jPanel4Layout.setHorizontalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel4Layout.createSequentialGroup()
                .addGap(16, 16, 16)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addGap(2, 2, 2)
                        .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtcantidad, javax.swing.GroupLayout.PREFERRED_SIZE, 92, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel20))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel24)
                            .addComponent(txtfecha, javax.swing.GroupLayout.PREFERRED_SIZE, 155, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jboxproductos, javax.swing.GroupLayout.PREFERRED_SIZE, 192, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel19))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel26)
                            .addComponent(txtprecio, javax.swing.GroupLayout.PREFERRED_SIZE, 88, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addGap(42, 42, 42)
                        .addComponent(jButton3, javax.swing.GroupLayout.PREFERRED_SIZE, 104, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(51, 51, 51)
                        .addComponent(jButton13, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel4Layout.createSequentialGroup()
                        .addGap(95, 95, 95)
                        .addComponent(btnventas, javax.swing.GroupLayout.PREFERRED_SIZE, 152, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(150, Short.MAX_VALUE))
        );
        jPanel4Layout.setVerticalGroup(
            jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel4Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel19)
                    .addComponent(jLabel26))
                .addGap(12, 12, 12)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jboxproductos, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtprecio, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton13, javax.swing.GroupLayout.PREFERRED_SIZE, 42, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton3, javax.swing.GroupLayout.DEFAULT_SIZE, 43, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel20)
                    .addComponent(jLabel24))
                .addGap(5, 5, 5)
                .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnventas, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(jPanel4Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(txtcantidad, javax.swing.GroupLayout.PREFERRED_SIZE, 46, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(txtfecha, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addGap(56, 56, 56))
        );

        jtabla.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jtabla.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jtablaMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(jtabla);

        javax.swing.GroupLayout jp2Layout = new javax.swing.GroupLayout(jp2);
        jp2.setLayout(jp2Layout);
        jp2Layout.setHorizontalGroup(
            jp2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jp2Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jp2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel4, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.Alignment.TRAILING))
                .addContainerGap())
        );
        jp2Layout.setVerticalGroup(
            jp2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jp2Layout.createSequentialGroup()
                .addComponent(jPanel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 232, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(324, Short.MAX_VALUE))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(jp2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jp2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void jtablaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jtablaMouseClicked

    }//GEN-LAST:event_jtablaMouseClicked

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        try {
            //definicion de variable
            String nombreProducto = (String) jboxproductos.getSelectedItem();
            int cantidadVenta = Integer.parseInt(txtcantidad.getText());

            // Obtener el IdProducto asociado al nombre del producto seleccionado
            String queryIdProducto = "SELECT IdProducto, Cantidad FROM Producto WHERE Nombre = ?";
            try (PreparedStatement psIdProducto = cn.prepareStatement(queryIdProducto)) {
                psIdProducto.setString(1, nombreProducto);
                ResultSet rsIdProducto = psIdProducto.executeQuery();

                if (rsIdProducto.next()) {
                    int idProducto = rsIdProducto.getInt("IdProducto");
                    int cantidadDisponible = rsIdProducto.getInt("Cantidad");

                    // Verificar si hay suficiente cantidad disponible para la venta
                    if (cantidadVenta > cantidadDisponible) {
                        JOptionPane.showMessageDialog(null, "No hay suficiente cantidad disponible para la venta.");
                        return; // Salir del método si la validación no es exitosa
                    }

                    // Obtener la fecha del JCalendar
                    Date fechaSeleccionada = txtfecha.getDate();

                    // Formatear la fecha al formato adecuado para tu base de datos
                    SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
                    String fechaFormateada = sdf.format(fechaSeleccionada);

                    // Realizar la inserción en la tabla de ventas
                    String queryVenta = "INSERT INTO Venta (IdProducto, Producto, Cantidad, FechaVenta, TotalVenta) VALUES (?, ?, ?, ?, ?)";
                    try (PreparedStatement psVenta = cn.prepareStatement(queryVenta)) {
                        double precioUnitario = Double.parseDouble(txtprecio.getText());
                        double totalVenta = cantidadVenta * precioUnitario;

                        psVenta.setInt(1, idProducto);
                        psVenta.setString(2, nombreProducto);
                        psVenta.setInt(3, cantidadVenta);
                        psVenta.setString(4, fechaFormateada);
                        psVenta.setDouble(5, totalVenta);
                        psVenta.executeUpdate();

                        JOptionPane.showMessageDialog(null, "Datos guardados correctamente");
                        mostrardatos();
                        limpiarcampos();
                    }
                } else {
                    JOptionPane.showMessageDialog(null, "No se encontró el producto seleccionado.");
                }
            }
        } catch (SQLException e) {
            System.out.println("Error al registrar: " + e);
        }

    }//GEN-LAST:event_jButton3ActionPerformed

    private void jButton13ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton13ActionPerformed
        try {
            int fila = jtabla.getSelectedRow();

            if (fila == -1) {
                JOptionPane.showMessageDialog(null, "Selecciona una fila para eliminar");
            } else {
                String id = jtabla.getValueAt(fila, 0).toString();
                String query = "DELETE FROM Venta WHERE idVenta=" + id;

                Statement stmt = cn.createStatement();
                int rowsAffected = stmt.executeUpdate(query);

                if (rowsAffected > 0) {
                    JOptionPane.showMessageDialog(this, "Datos eliminados correctamente");
                    mostrardatos();
                    limpiarcampos();
                } else {
                    JOptionPane.showMessageDialog(null, "No se pudo eliminar el registro");
                }
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Error al eliminar datos: " + e.getMessage());
        }
    }//GEN-LAST:event_jButton13ActionPerformed

    private void jboxproductosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jboxproductosActionPerformed

    }//GEN-LAST:event_jboxproductosActionPerformed

    private void txtcantidadActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtcantidadActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtcantidadActionPerformed

    private void txtprecioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtprecioActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_txtprecioActionPerformed

    private void btnventasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnventasActionPerformed
        moverVentaAHistorial();
    }//GEN-LAST:event_btnventasActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnventas;
    private javax.swing.JButton jButton13;
    private javax.swing.JButton jButton3;
    private javax.swing.JLabel jLabel19;
    private javax.swing.JLabel jLabel20;
    private javax.swing.JLabel jLabel24;
    private javax.swing.JLabel jLabel26;
    private javax.swing.JPanel jPanel4;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JComboBox<String> jboxproductos;
    private javax.swing.JPanel jp2;
    private javax.swing.JTable jtabla;
    private javax.swing.JTextField txtcantidad;
    private com.toedter.calendar.JDateChooser txtfecha;
    private javax.swing.JTextField txtprecio;
    // End of variables declaration//GEN-END:variables

    private void mostrardatos() {
        DefaultTableModel modelo = new DefaultTableModel();
        modelo.addColumn("IdVenta");
        modelo.addColumn("IdProducto");
        modelo.addColumn("Producto");
        modelo.addColumn("Cantidad");
        modelo.addColumn("FechaVenta");
        modelo.addColumn("TotalVenta");
        jtabla.setModel(modelo);

        String consultasql = "SELECT * FROM Venta";
        String[] data = new String[6];

        try (Statement st = cn.createStatement(); ResultSet rs = st.executeQuery(consultasql)) {

            while (rs.next()) {
                data[0] = rs.getString(1);
                data[1] = rs.getString(2);
                data[2] = rs.getString(3);
                data[3] = rs.getString(4);
                data[4] = rs.getString(5);
                data[5] = rs.getString(6);
                modelo.addRow(data);
            }

        } catch (SQLException e) {
            System.out.println("Error al mostrar datos: " + e);
        }
    }

    private void limpiarcampos() {
        txtcantidad.setText("");
        txtfecha.setDate(Calendar.getInstance().getTime());
    }

    private void cargarproductos() {
        String sql = "SELECT * FROM Producto";
        Statement st;

        try {
            st = cn.createStatement();
            ResultSet rs = st.executeQuery(sql);

            // Limpiar el combo box antes de agregar nuevos elementos
            jboxproductos.removeAllItems();
            jboxproductos.addItem("Seleccione Producto: ");

            // Utilizar una lista para almacenar los productos
            List<Producto> productos = new ArrayList<>();

            while (rs.next()) {
                String nombreProducto = rs.getString("Nombre");
                double precioProducto = rs.getDouble("PrecioUnitario");

                // Crear una instancia de Producto y agregarla a la lista
                Producto producto = new Producto(nombreProducto, precioProducto);
                productos.add(producto);

                // Agregar el nombre del producto al JComboBox
                jboxproductos.addItem(nombreProducto);
            }

            // Agregar un listener para manejar la selección en el JComboBox
            jboxproductos.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    // Obtener el producto seleccionado
                    String nombreProducto = (String) jboxproductos.getSelectedItem();

                    // Mostrar el precio en el JTextField
                    actualizarPrecioEnTextField(nombreProducto, productos);
                }
            });

        } catch (SQLException e) {
            System.out.println("Error al cargar los productos " + e);
        }
    }

    private void actualizarPrecioEnTextField(String nombreProducto, List<Producto> productos) {
        // Verificar que se haya seleccionado un producto válido
        if (!nombreProducto.equals("Seleccione Producto: ")) {
            // Buscar el producto en la lista
            Optional<Producto> productoSeleccionado = productos.stream()
                    .filter(producto -> producto.getNombre().equals(nombreProducto))
                    .findFirst();

            // Verificar si se encontró el producto
            if (productoSeleccionado.isPresent()) {
                // Obtener el precio del producto y mostrarlo en el JTextField
                double precioProducto = productoSeleccionado.get().getPrecio();
                txtprecio.setText(String.valueOf(precioProducto));
            } else {
                // Manejar la situación cuando el producto no se encuentra en la lista
                txtprecio.setText(""); // Puedes dejar el campo vacío o establecer un valor predeterminado
            }
        } else {
            // En caso de que se seleccione "Seleccione Producto:", puedes manejarlo como desees
            txtprecio.setText(""); // Puedes dejar el campo vacío o establecer un valor predeterminado
        }
    }

    private void moverVentaAHistorial() {
        try (CallableStatement cs = (CallableStatement) cn.prepareCall("{CALL MoverDatosVentaAHistorial()}")) {
            cs.execute();
            System.out.println("Procedimiento almacenado ejecutado correctamente");
            mostrardatos(); 
        } catch (SQLException e) {
            e.printStackTrace();
            System.out.println("Error al ejecutar el procedimiento almacenado: " + e.getMessage());
        }
    }

}
