using Datos;
using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_Final_Grupo1
{
    public partial class Administrador : Form
    {
        private TipoIvaLogica tipoIvaLogica;
        private UnidadMedidaLogica unidadMedidaLogica;
        private ProductoLogica productoLogica;
        private ClienteLogica clienteLogica;

        public Administrador()
        {
            InitializeComponent();
            tipoIvaLogica = new TipoIvaLogica();
            unidadMedidaLogica = new UnidadMedidaLogica();
            productoLogica = new ProductoLogica();
            clienteLogica = new ClienteLogica();
        }


        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion5.Text = "TipoIva";
            lblOpcion1.Text = "Descripcion";
            lblOpcion2.Text = "Porcentaje";
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = true;
            txtOpcion3.Visible = false;
            btn_Agregar.Visible = true;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = true;
            cboOpcion.Visible = false;
            cboUnidadMedida.Visible = false;
            lblOpcion3.Visible = false;
            ConfigurarColumnasTipoIvaDataGridView();
            CargarDatosTipoIvaDataGridView();
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion5.Text = "TipoIva";
            lblOpcion1.Text = "Descripcion";
            lblOpcion2.Text = "Porcentaje";
            lblOpcion3.Visible = false;
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = true;
            cboOpcion.Visible = true;
            txtOpcion3.Visible = false;
            btn_Agregar.Visible = false;
            btn_Eliminar.Visible = false;
            btn_Modificar.Visible = true;
            chkHabilitado.Visible = true;
            cboUnidadMedida.Visible = false;
            ConfigurarColumnasTipoIvaDataGridView();
            CargarDatosTipoIvaDataGridView();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion5.Text = "TipoIva";
            lblOpcion1.Text = "Descripcion";
            lblOpcion2.Text = "Porcentaje";
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = true;
            btn_Agregar.Visible = false;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = true;
            chkHabilitado.Visible = true;
            cboOpcion.Visible= true;

            ConfigurarColumnasTipoIvaDataGridView();
            CargarDatosTipoIvaDataGridView();
        }
        private void altaUnidadDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = false;
            lblOpcion5.Text = "AltaUnidadMedida";
            txtOpcion1.Text = "";
            lblOpcion1.Text = "Descripcion";
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = false;
            btn_Agregar.Visible = true;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = true;
            cboOpcion.Visible = false;
            ConfigurarColumnasUnidadDeMedidaDataGridView();
            CargarDatosUnidadDeMedidaDataGridView();
            //CargarDatosUnidadMedidaSeleccionado();
            //CargarUnidadesMedidaEnComboBox();
        }
        private void modificacionUnidadDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion5.Text = "AltaUnidadMedida";
            lblOpcion1.Text = "Descripcion";
            txtOpcion1.Visible = true;
            btn_Agregar.Visible = false;
            btn_Modificar.Visible = true;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = true;
            cboOpcion.Visible = true;
            ConfigurarColumnasUnidadDeMedidaDataGridView();
            CargarDatosUnidadDeMedidaDataGridView();
            //CargarDatosUnidadMedidaSeleccionado();
            //CargarUnidadesMedidaEnComboBox();
        }
        private void eliminarUnidadDeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion5.Text = "AltaUnidadMedida";
            lblOpcion1.Visible = true;
            lblOpcion1.Text = "Descripcion";
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = false;
            btn_Agregar.Visible = false;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = true;
            chkHabilitado.Visible = true;
            cboOpcion.Visible = true;
            ConfigurarColumnasUnidadDeMedidaDataGridView();
            CargarDatosUnidadDeMedidaDataGridView();
            CargarDatosUnidadMedidaSeleccionado();
            CargarUnidadesMedidaEnComboBox();
        }
        private void altaProductoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Alta
            LimpiarCampos();
            lblOpcion5.Text = "Producto";
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion3.Visible = true;

            lblOpcion1.Text = "Descripcion";
            lblOpcion2.Text = "Unidad de Medida";
            lblOpcion3.Text = "Valor Unitario";

            txtOpcion1.Visible = true;
            txtOpcion2.Visible = false;
            txtOpcion3.Visible = true;
            btn_Agregar.Visible = true;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = true;
            cboUnidadMedida.Visible = true;
            cboOpcion.Visible = false;
            ConfigurarColumnasProductoDataGridView();
            CargarDatosProductoDataGridView();
        }
        private void modificacionProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lblOpcion5.Text = "Producto";
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion3.Visible = true;
            lblOpcion1.Text = "Descripcion";
            lblOpcion2.Text = "Unidad de Medida";
            lblOpcion3.Text = "Valor Unitario";
            txtOpcion1.Visible = true;
            txtOpcion2.Visible = false;
            txtOpcion3.Visible = true;
            btn_Agregar.Visible = false;
            btn_Modificar.Visible = true;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = true;
            cboOpcion.Visible = true;
            cboUnidadMedida.Visible = true;
            cboTipoIva.Visible = false;
            ConfigurarColumnasProductoDataGridView();
            CargarDatosProductoDataGridView();
            CargarDatosUnidadMedidaSeleccionado();
            CargarDatosProductoSeleccionado();
            CargarUnidadesMedidaEnComboBoxProducto();
            CargarUnidadesMedidaEnComboBox();
            CargarProductosEnComboBox();
            CargarDatosProductoSeleccionado();
        }
        private void eliminarProductoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            lblOpcion5.Text = "Producto";
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = false;
            lblOpcion3.Visible = true;

            lblOpcion1.Text = "Descripcion";
            lblOpcion2.Text = "Unidad de Medida";
            lblOpcion3.Text = "Valor Unitario";

            txtOpcion1.Visible = true;
            txtOpcion2.Visible = false;
            txtOpcion3.Visible = true;
            btn_Agregar.Visible = false;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = true;
            chkHabilitado.Visible = false;
            cboUnidadMedida.Visible = false;
            cboOpcion.Visible = true;
            //ConfigurarColumnasProductoDataGridView();
            CargarDatosProductoDataGridView();


            //CargarUnidadesMedidaEnComboBox();
            //CargarUnidadesMedidaEnComboBoxProducto();
            //CargarDatosUnidadMedidaSeleccionado();
            CargarDatosProductoSeleccionado();
            CargarProductosEnComboBox();
        }
        private void altaClienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion3.Visible = true;
            lblOpcion4.Visible = true;
            lblOpcion6.Visible = true;
            dtpFechaAlta.Visible = true;
            dtpFechaBaja.Visible = true;

            lblOpcion5.Text = "Cliente";
            lblOpcion1.Text = "Razon Social";
            lblOpcion2.Text = "Limite de Credito";
            lblOpcion3.Text = "Tipo de Iva";
            lblOpcion4.Text = "Fecha Alta";
            lblOpcion6.Text = "Fecha Baja";

            txtOpcion1.Visible = true;
            txtOpcion2.Visible = true;
            txtOpcion3.Visible = false;
            txtOpcion4.Visible = false;
            txtOpcion6.Visible = false;

            btn_Agregar.Visible = true;
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = false;
            cboOpcion.Visible = false;
            cboUnidadMedida.Visible = false;

            ConfigurarColumnasClienteDataGridView();
            CargarDatosClienteDataGridView();
            CargarTipoIvaClienteEnComboBoxProducto();
        }

        private void modificacionClienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvOpcion.Rows.Clear();
            lblOpcion1.Visible = true;
            lblOpcion2.Visible = true;
            lblOpcion3.Visible = true;
            lblOpcion4.Visible = true;
            lblOpcion6.Visible = true;
            dtpFechaAlta.Visible = true;
            dtpFechaBaja.Visible = true;

            lblOpcion5.Text = "Cliente";
            lblOpcion1.Text = "Razon Social";
            lblOpcion2.Text = "Limite de Credito";
            lblOpcion3.Text = "Tipo de Iva";
            lblOpcion4.Text = "Fecha Alta";
            lblOpcion6.Text = "Fecha Baja";

            txtOpcion1.Visible = true;
            txtOpcion2.Visible = true;
            txtOpcion3.Visible = false;
            txtOpcion4.Visible = false;
            txtOpcion6.Visible = false;

            btn_Agregar.Visible = false;
            btn_Modificar.Visible = true;
            btn_Eliminar.Visible = false;
            chkHabilitado.Visible = false;
            cboOpcion.Visible = true;
            cboUnidadMedida.Visible = false;
            cboTipoIva.Visible = true;

            ConfigurarColumnasClienteDataGridView();
            CargarDatosClienteDataGridView();
            CargarTipoIvaClienteEnComboBoxProducto();
            CargarDatosClienteSeleccionado();
            CargarClientesEnComboBox();
        }

        private void eliminarClienteToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurarColumnasClienteDataGridView()
        {
            dgvOpcion.Columns.Clear(); // Limpiar las columnas existentes
                        
            dgvOpcion.Columns.Add("Razon Social", "RazonSocial");
            dgvOpcion.Columns.Add("Limite de Credito", "LimiteCredito");
            dgvOpcion.Columns.Add("Tipo de Iva", "TipoIva");
            dgvOpcion.Columns.Add("Fecha Alta", "FechaAlta");
            dgvOpcion.Columns.Add("Fecha Baja", "FechaBaja");
        }
        private void CargarDatosClienteDataGridView()
        {
            List<Cliente> clientes = clienteLogica.ObtenerClientes();

            // Configura las columnas para Tipo de IVA
            ConfigurarColumnasClienteDataGridView();

            // Itera sobre la lista de tipos de IVA y agrega una fila por cada uno al DataGridView
            foreach (Cliente cliente in clientes)
            {
                string descripcionTipoIva = tipoIvaLogica.ObtenerDescripcionTipoIva(cliente.TipoIva);
                dgvOpcion.Rows.Add(cliente.RazonSocial,cliente.LimiteCredito, descripcionTipoIva, cliente.FechaAlta?.ToString("dd/MM/yyyy"), cliente.FechaBaja?.ToString("dd/MM/yyyy") ?? ""); ;
            }
        }
        private void ConfigurarColumnasTipoIvaDataGridView()
        {
            dgvOpcion.Columns.Clear(); // Limpiar las columnas existentes

            // Configurar las columnas para Tipo de IVA
            dgvOpcion.Columns.Add("Descripcion", "Descripción");
            dgvOpcion.Columns.Add("Porcentaje", "Porcentaje");
            dgvOpcion.Columns.Add("Habilitado", "Habilitado");
        }
        private void CargarTiposIvaEnComboBox()
        {
            List<TipoIva> tiposIva = tipoIvaLogica.ObtenerTiposIva();

            // Agrego un elemento vacío al principio de la lista
            tiposIva.Insert(0, new TipoIva { IdTipoIva = 0, Descripcion = "Seleccionar" });

            // Asigna la lista de tipos de IVA al ComboBox
            cboOpcion.DataSource = tiposIva;
            cboOpcion.DisplayMember = "Descripcion"; // Muestro la descripción en el ComboBox
            cboOpcion.ValueMember = "IdTipoIva"; // Uso el IdTipoIva como valor seleccionado

            //cboOpcion.SelectedIndex = 0;
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lblOpcion5.Text)
                {
                    case "AltaUnidadMedida":
                        if (!string.IsNullOrEmpty(txtOpcion1.Text))
                        {
                            UnidadDeMedida unidadMedida = new UnidadDeMedida
                            {
                                Descripcion = txtOpcion1.Text,
                                Habilitado = chkHabilitado.Checked ? 1 : 0
                            };

                            unidadMedidaLogica.AgregarUnidadMedida(unidadMedida);

                            // Limpiar los campos después de agregar
                            LimpiarCampos();
                            // recargar el ComboBox con la lista actualizada de tipos de IVA                  
                            CargarUnidadesMedidaEnComboBox();
                            ActualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, complete la Descripcion.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case "TipoIva":
                        if (!string.IsNullOrEmpty(txtOpcion1.Text) && !string.IsNullOrEmpty(txtOpcion2.Text))
                        {
                            TipoIva nuevoTipoIva = new TipoIva
                            {
                                Descripcion = txtOpcion1.Text,
                                Porcentaje = Convert.ToDouble(txtOpcion2.Text),
                                Habilitado = chkHabilitado.Checked ? 1 : 0
                            };

                            tipoIvaLogica.AgregarTipoIva(nuevoTipoIva);

                            LimpiarCampos();
                            CargarTiposIvaEnComboBox();
                            ActualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case "Producto":
                        if (!string.IsNullOrEmpty(txtOpcion1.Text) && !string.IsNullOrEmpty(txtOpcion3.Text))
                        {
                            Producto nuevoProducto = new Producto
                            {
                                Descripcion = txtOpcion1.Text,
                                IdUnidadDeMedida = Convert.ToInt32(cboUnidadMedida.SelectedValue),
                                ValorUnitario = Convert.ToDouble(txtOpcion3.Text),
                                Habilitado = chkHabilitado.Checked ? 1 : 0
                            };

                            productoLogica.AgregarProducto(nuevoProducto);

                            LimpiarCampos();
                            CargarProductosEnComboBox();
                            CargarDatosProductoDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case "Cliente":
                        if (!string.IsNullOrEmpty(txtOpcion1.Text))//agregar validaciones
                        {
                            Cliente nuevoCliente = new Cliente
                            {
                                RazonSocial = txtOpcion1.Text,
                                LimiteCredito = Convert.ToDouble(txtOpcion2.Text),
                                TipoIva = Convert.ToInt32(cboTipoIva.SelectedValue),
                                FechaAlta = dtpFechaAlta.Value.Date,
                                FechaBaja = dtpFechaBaja.Value.Date
                            };

                            clienteLogica.AgregarCliente(nuevoCliente);

                            LimpiarCampos();
                            CargarDatosClienteDataGridView();
                            ActualizarDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    default:
                        // Manejar otro caso o no hacer nada
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lblOpcion5.Text)
                {
                    case "TipoIva":
                        // Obtén los datos del formulario 
                        TipoIva tipoIva = ObtenerDatosDelFormulario();
                        if (!string.IsNullOrEmpty(txtOpcion1.Text) && !string.IsNullOrEmpty(txtOpcion2.Text))
                        {
                            // Llama al método de la capa de lógica para editar el tipo de IVA
                            bool resultadoTipoIva = tipoIvaLogica.EditarTipoIva(tipoIva);
                            ManejarResultadoEdicion(resultadoTipoIva, "Tipo de IVA");
                        }                      
                        break;

                    case "AltaUnidadMedida":
                        // Obtén los datos del formulario o de donde sea necesario
                        UnidadDeMedida unidadMedida = ObtenerDatosDelFormularioUnidadMedida();
                        if (!string.IsNullOrEmpty(txtOpcion1.Text))
                        {
                            // Llama al método de la capa de lógica para editar la unidad de medida
                            bool resultadoUnidadMedida = unidadMedidaLogica.EditarUnidadMedida(unidadMedida);
                            ManejarResultadoEdicion(resultadoUnidadMedida, "Unidad de Medida");
                        }                       
                        break;

                    case "Producto":
                        if (cboOpcion.SelectedIndex != 0)
                        {
                            // Obtén los datos del formulario o de donde sea necesario
                            Producto producto = ObtenerDatosDelFormularioProducto();
                            if (!string.IsNullOrEmpty(txtOpcion1.Text) || !string.IsNullOrEmpty(txtOpcion3.Text) || cboUnidadMedida.SelectedIndex != 0)
                            {
                                // Llama al método de la capa de lógica para editar el producto
                                bool resultadoProducto = productoLogica.EditarProducto(producto);
                                ManejarResultadoEdicion(resultadoProducto, "Producto");
                            }
                        }
                        break;
                    case "Cliente":
                        if (cboOpcion.SelectedIndex != 0)
                        {
                            // Obtén los datos del formulario o de donde sea necesario
                            Cliente cliente = ObtenerDatosDelFormularioCliente();
                            if (!string.IsNullOrEmpty(txtOpcion1.Text))
                            {
                                // Llama al método de la capa de lógica para editar el producto
                                bool resultadoCliente= clienteLogica.EditarCliente(cliente);
                                ManejarResultadoEdicion(resultadoCliente, "Cliente");
                            }
                        }
                        break;
                    default:                        
                        break;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción específica o mostrar un mensaje genérico de error
                MessageBox.Show($"Error: Verifique los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ManejarResultadoEdicion(bool resultado, string tipo)
        {
            if (resultado)
            {
                MessageBox.Show($"{tipo} editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarDataGridView();

                // Según el tipo, actualiza los controles específicos
                switch (tipo)
                {
                    case "Tipo de IVA":
                        CargarDatosTipoIvaDataGridView();
                        CargarDatosTipoIvaSeleccionado();
                        CargarTiposIvaEnComboBox();
                        break;

                    case "Unidad de Medida":
                        CargarDatosUnidadDeMedidaDataGridView();
                        CargarDatosUnidadMedidaSeleccionado();
                        CargarUnidadesMedidaEnComboBox();
                        break;

                    case "Producto":
                        CargarDatosProductoDataGridView();
                        CargarDatosProductoSeleccionado();
                        CargarProductosEnComboBox();
                        break;

                    case "Cliente":
                        CargarDatosClienteDataGridView();
                        CargarDatosClienteSeleccionado();
                        CargarClientesEnComboBox();
                        break;

                    default:
                        break;
                }

                // Vuelve a la opción Seleccionar del ComboBox
                cboOpcion.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show($"Error al editar {tipo}. Verificar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lblOpcion5.Text)
                {
                    case "TipoIva":
                        // Obtén el IdTipoIva del elemento seleccionado en el ComboBox o DataGridView
                        if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is TipoIva tipoIvaSeleccionado)
                        {
                            int idTipoIva = tipoIvaSeleccionado.IdTipoIva;
                            // Llama al método de la capa de lógica para eliminar el tipo de IVA
                            bool resultado = tipoIvaLogica.EliminarTipoIva(idTipoIva);
                            ManejarResultadoEliminar(resultado, "TipoIva");
                            // Puedes manejar el resultado de acuerdo a tus necesidades (mostrar mensajes, actualizar UI, etc.)
                        }
                        break;

                    case "AltaUnidadMedida":
                        // Obtén el IdTipoIva del elemento seleccionado en el ComboBox o DataGridView
                        if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is UnidadDeMedida unidadMedidaSeleccionado)
                        {
                            int idUnidadMedida = unidadMedidaSeleccionado.IdUnidadDeMedida;

                            // Llama al método de la capa de lógica para eliminar el tipo de IVA
                            bool resultado = unidadMedidaLogica.EliminarUnidadMedida(idUnidadMedida);
                            ManejarResultadoEliminar(resultado, "AltaUnidadMedida");                           
                        }
                        break;

                    case "Producto":
                        // Obtén el IdTipoIva del elemento seleccionado en el ComboBox o DataGridView
                        if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is Producto productoSeleccionado)
                        {
                            int idProducto = productoSeleccionado.IdProducto;

                            // Llama al método de la capa de lógica para eliminar el tipo de IVA
                            bool resultado = productoLogica.EliminarProducto(idProducto);
                            ManejarResultadoEliminar(resultado, "Producto");
                           
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show($"Error: Verifique los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void ManejarResultadoEliminar(bool resultado, string tipo)
        {
            if (resultado)
            {
                MessageBox.Show($"{tipo} Eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarDataGridView();

                // Según el tipo, actualiza los controles específicos
                switch (tipo)
                {
                    case "Tipo de IVA":
                        // Actualiza el ComboBox y/o DataGridView después de la eliminación
                        CargarTiposIvaEnComboBox();
                        ActualizarDataGridView();
                        break;

                    case "Unidad de Medida":
                        CargarUnidadesMedidaEnComboBox();
                        ActualizarDataGridView();
                        break;

                    case "Producto":
                        CargarProductosEnComboBox();
                        CargarDatosProductoDataGridView();
                        ActualizarDataGridView();
                        break;

                    default:
                        break;
                }

                // Vuelve a la opción Seleccionar del ComboBox
                cboOpcion.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show($"Error al Eliminar {tipo}. Verificar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtOpcion1.Text = "";
            txtOpcion2.Text = "";
            txtOpcion3.Text = "";
            lblOpcion5.Text = "";
            if (lblOpcion5.Text =="Producto")
            {
            cboUnidadMedida.SelectedIndex = 0;
            }
            else if (lblOpcion5.Text == "Cliente")
            {
                cboTipoIva.SelectedIndex = 0;
            }
        }
        private void ActualizarDataGridView()
        {            
            if (lblOpcion5.Text == "TipoIva")
            {
                dgvOpcion.Rows.Clear();
                // Obtener la lista actualizada de tipos de IVA
                List<TipoIva> tiposIva = tipoIvaLogica.ObtenerTiposIva();

                // Iterar sobre la lista y agregar filas al DataGridView
                foreach (TipoIva tipoIva in tiposIva)
                {
                    dgvOpcion.Rows.Add(tipoIva.Descripcion, tipoIva.Porcentaje, tipoIva.Habilitado == 1 ? "Sí" : "No");
                }
            }
            else if (lblOpcion5.Text == "AltaUnidadMedida")
            {
                dgvOpcion.Rows.Clear();
                // Obtener la lista actualizada de tipos de IVA
                List<UnidadDeMedida> unidadmedidas = unidadMedidaLogica.ObtenerUnidadMedida();

                // Iterar sobre la lista y agregar filas al DataGridView
                foreach (UnidadDeMedida unidadmedida in unidadmedidas)
                {
                    dgvOpcion.Rows.Add(unidadmedida.Descripcion, unidadmedida.Habilitado == 1 ? "Sí" : "No");
                }
            }
            else if (lblOpcion5.Text == "Producto")
            {
                dgvOpcion.Rows.Clear();
                // Obtener la lista actualizada de tipos de IVA
                List<Producto> productos = productoLogica.ObtenerProductos();

                // Iterar sobre la lista y agregar filas al DataGridView
                foreach (Producto prod in productos)
                {
                    dgvOpcion.Rows.Add(prod.Descripcion, prod.IdUnidadDeMedida, prod.ValorUnitario, prod.Habilitado == 1 ? "Sí" : "No");
                }
            }
            else if (lblOpcion5.Text == "Cliente")
            {
                dgvOpcion.Rows.Clear();
                // Obtener la lista actualizada de tipos de IVA
                List<Cliente> clientes = clienteLogica.ObtenerClientes();

                // Iterar sobre la lista y agregar filas al DataGridView
                foreach (Cliente cli in clientes)
                {
                    dgvOpcion.Rows.Add(cli.RazonSocial, cli.LimiteCredito, cli.TipoIva, cli.FechaBaja,cli.FechaAlta);
                }
            }


        }
        private void CargarDatosTipoIvaDataGridView()
        {
            List<TipoIva> tiposIva = tipoIvaLogica.ObtenerTiposIva();

            // Configura las columnas para Tipo de IVA
            ConfigurarColumnasTipoIvaDataGridView();

            // Itera sobre la lista de tipos de IVA y agrega una fila por cada uno al DataGridView
            foreach (TipoIva tipoIva in tiposIva)
            {
                dgvOpcion.Rows.Add(tipoIva.Descripcion, tipoIva.Porcentaje, tipoIva.Habilitado == 1 ? "Sí" : "No");
            }
        }      
        private void CargarProductosEnComboBox()
        {
            List<Producto> productos = productoLogica.ObtenerProductos();

            // Agrego un elemento vacío al principio de la lista
            productos.Insert(0, new Producto { IdProducto = 0, Descripcion = "Seleccionar" });

            // Asigna la lista de productos al ComboBox
            cboOpcion.DataSource = productos;
            cboOpcion.DisplayMember = "Descripcion"; // Muestro la descripción en el ComboBox
            cboOpcion.ValueMember = "IdProducto"; // Uso el IdProducto como valor seleccionado

            cboOpcion.SelectedIndex = 0;// Selecciona el elemento vacío por defecto
        }
        private TipoIva ObtenerDatosDelFormulario()
        {
            // Creo un objeto TipoIva y asigno los valores
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is TipoIva tipoIvaSeleccionado)
            {
                // Utiliza los datos del objeto seleccionado en el ComboBox
                tipoIvaSeleccionado.Descripcion = txtOpcion1.Text;
                tipoIvaSeleccionado.Porcentaje = Convert.ToDouble(txtOpcion2.Text);
                tipoIvaSeleccionado.Habilitado = chkHabilitado.Checked ? 1 : 0;

                return tipoIvaSeleccionado;
            }

            return null;
        }
        private UnidadDeMedida ObtenerDatosDelFormularioUnidadMedida()
        {
            // Creo un objeto TipoIva y asigno los valores
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is UnidadDeMedida tipoIvaSeleccionado)
            {
                // Utiliza los datos del objeto seleccionado en el ComboBox
                tipoIvaSeleccionado.Descripcion = txtOpcion1.Text;
                tipoIvaSeleccionado.Habilitado = chkHabilitado.Checked ? 1 : 0;

                return tipoIvaSeleccionado;
            }

            return null;
        }
        private Producto ObtenerDatosDelFormularioProducto()
        {
            // Creo un objeto Producto y asigno los valores
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is Producto productoSeleccionado)
            {
                // Utiliza los datos del objeto seleccionado en el ComboBox
                productoSeleccionado.Descripcion = txtOpcion1.Text;
                productoSeleccionado.ValorUnitario = double.Parse(txtOpcion3.Text);

                // Obtén el objeto UnidadDeMedida seleccionado en el ComboBox
                if (cboUnidadMedida.SelectedItem is UnidadDeMedida unidadMedidaSeleccionada)
                {
                    productoSeleccionado.IdUnidadDeMedida = unidadMedidaSeleccionada.IdUnidadDeMedida;
                }

                productoSeleccionado.Habilitado = chkHabilitado.Checked ? 1 : 0;

                return productoSeleccionado;
            }

            return null;
        }
        private Cliente ObtenerDatosDelFormularioCliente()
        {
            // Creo un objeto Cliente y asigno los valores
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is Cliente clienteSeleccionado)
            {
                // Utiliza los datos del objeto seleccionado en el ComboBox
                clienteSeleccionado.RazonSocial = txtOpcion1.Text;
                clienteSeleccionado.LimiteCredito = double.Parse(txtOpcion2.Text);

                // Tengo el valor seleccionado en el ComboBox
                if (cboTipoIva.SelectedItem != null)
                {
                    // Ajusta según la propiedad correcta en tu clase Cliente
                    clienteSeleccionado.TipoIva = Convert.ToInt32(cboTipoIva.SelectedValue);
                }

                
                clienteSeleccionado.FechaAlta = dtpFechaAlta.Value;
                clienteSeleccionado.FechaBaja = dtpFechaBaja.Value;

                return clienteSeleccionado;
            }

            return null;
        }
        private void CargarDatosTipoIvaSeleccionado()
        {
            // Verifico si hay un elemento seleccionado en el ComboBox
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is TipoIva tipoIvaSeleccionado)
            {
                // Verifico si no es el elemento inicial ("Seleccionar")
                if (tipoIvaSeleccionado.IdTipoIva != 0)
                {
                    // Cargo los datos del tipoIvaSeleccionado 
                    txtOpcion1.Text = tipoIvaSeleccionado.Descripcion;
                    txtOpcion2.Text = tipoIvaSeleccionado.Porcentaje.ToString();
                    chkHabilitado.Checked = tipoIvaSeleccionado.Habilitado == 1;
                }
                else
                {
                    // Si es el elemento Seleccionar dejo los txtBox vacios
                    txtOpcion1.Text = "";
                    txtOpcion2.Text = "";
                    chkHabilitado.Checked = false;
                }
            }
        }
        private void cboOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblOpcion5.Text == "AltaUnidadMedida")
            {
                CargarDatosUnidadMedidaSeleccionado();
            }
            else if (lblOpcion5.Text == "TipoIva")
            {
                CargarDatosTipoIvaSeleccionado();
            }
            else if (lblOpcion5.Text == "Producto")
            {
                CargarDatosProductoSeleccionado();
            }
            else if (lblOpcion5.Text == "Cliente")
            {
                CargarDatosClienteSeleccionado();
            }

        }
        private void ConfigurarColumnasUnidadDeMedidaDataGridView()
        {
            dgvOpcion.Columns.Clear(); // Limpiar las columnas existentes
            // Configurar las columnas para Unidad de Medida
            dgvOpcion.Columns.Add("Descripcion", "Descripción");
            dgvOpcion.Columns.Add("Habilitado", "Habilitado");
        }
        private void CargarDatosUnidadDeMedidaDataGridView()
        {
            List<UnidadDeMedida> unidadesDeMedida = unidadMedidaLogica.ObtenerUnidadMedida();
            // Configura las columnas para Unidad de Medida
            ConfigurarColumnasUnidadDeMedidaDataGridView();
            // Itera sobre la lista de unidades de medida y agrega una fila por cada una al DataGridView
            foreach (UnidadDeMedida unidadMedida in unidadesDeMedida)
            {
                dgvOpcion.Rows.Add(unidadMedida.Descripcion, unidadMedida.Habilitado == 1 ? "Sí" : "No");
            }
        }
        private void CargarDatosUnidadMedidaSeleccionado()
        {
            // Verifico si hay un elemento seleccionado en el ComboBox
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is UnidadDeMedida unidadMedida)
            {
                // Verifico si no es el elemento inicial ("Seleccionar")
                if (unidadMedida.IdUnidadDeMedida != 0)
                {
                    // Cargo los datos del tipoIvaSeleccionado 
                    txtOpcion1.Text = unidadMedida.Descripcion;
                    chkHabilitado.Checked = unidadMedida.Habilitado == 1;
                }
                else
                {
                    // Si es el elemento Seleccionar dejo los txtBox vacios
                    txtOpcion1.Text = "";
                    chkHabilitado.Checked = false;
                }
            }
        }
        private void CargarUnidadesMedidaEnComboBox()
        {
            List<UnidadDeMedida> unidadesMedidas = unidadMedidaLogica.ObtenerUnidadMedida();

            // Agrego un elemento vacío al principio de la lista
            unidadesMedidas.Insert(0, new UnidadDeMedida { IdUnidadDeMedida = 0, Descripcion = "Seleccionar" });

            // Asigna la lista de tipos de IVA al ComboBox
            cboOpcion.DataSource = unidadesMedidas;
            cboOpcion.DisplayMember = "Descripcion"; // Muestro la descripción en el ComboBox
            cboOpcion.ValueMember = "idUnidadDeMedida"; // Uso el IdTipoIva como valor seleccionado

            //cboOpcion.SelectedIndex = 0;
        }
        private void ConfigurarColumnasProductoDataGridView()
        {
            dgvOpcion.Columns.Clear(); // Limpiar las columnas existentes
                                       // Configurar las columnas para Producto
            dgvOpcion.Columns.Add("Descripcion", "Descripción");
            dgvOpcion.Columns.Add("IdUnidadDeMedida", "Unidad de Medida");
            dgvOpcion.Columns.Add("ValorUnitario", "Valor Unitario");
            dgvOpcion.Columns.Add("Habilitado", "Habilitado");
        }
        private void CargarDatosProductoDataGridView()
        {
            List<Producto> productos = productoLogica.ObtenerProductos();
            // Configura las columnas para Producto
            ConfigurarColumnasProductoDataGridView();
            // Itera sobre la lista de productos y agrega una fila por cada uno al DataGridView
            foreach (Producto producto in productos)
            {
                string descripcionUnidadMedida = unidadMedidaLogica.ObtenerDescripcionUnidadMedida(producto.IdUnidadDeMedida);
                dgvOpcion.Rows.Add(producto.Descripcion, descripcionUnidadMedida, producto.ValorUnitario, producto.Habilitado == 1 ? "Sí" : "No");
            }
        }
        private void CargarDatosProductoSeleccionado()
        {
            // Verifico si hay un elemento seleccionado en el ComboBox
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is Producto producto)
            {
                // Verifico si no es el elemento inicial ("Seleccionar")
                if (producto.IdProducto != 0)
                {
                    // Cargo los datos del producto seleccionado 
                    txtOpcion1.Text = producto.Descripcion;
                    txtOpcion2.Text = producto.IdUnidadDeMedida.ToString();
                    txtOpcion3.Text = producto.ValorUnitario.ToString();
                    chkHabilitado.Checked = producto.Habilitado == 1;
                }
                else
                {
                    // Si es el elemento Seleccionar, dejo los campos vacíos
                    txtOpcion1.Text = "";
                    txtOpcion2.Text = "";
                    txtOpcion3.Text = "";
                    chkHabilitado.Checked = false;
                }
            }
        }       
        private void cboUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosUnidadMedidaSeleccionado();
        }
        private void CargarUnidadesMedidaEnComboBoxProducto()
        {
            List<UnidadDeMedida> unidadesMedidas = unidadMedidaLogica.ObtenerUnidadMedida();

            // Agrego un elemento vacío al principio de la lista
            unidadesMedidas.Insert(0, new UnidadDeMedida { IdUnidadDeMedida = 0, Descripcion = "Seleccionar" });

            // Asigna la lista de tipos de IVA al ComboBox
            cboUnidadMedida.DataSource = unidadesMedidas;
            cboUnidadMedida.DisplayMember = "Descripcion"; // Muestro la descripción en el ComboBox
            cboUnidadMedida.ValueMember = "idUnidadDeMedida"; // Uso el IdTipoIva como valor seleccionado

            //cboOpcion.SelectedIndex = 0;
        }

        private void cboTipoIva_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosTipoIvaSeleccionado();
        }

        private void CargarTipoIvaClienteEnComboBoxProducto()
        {
            List<TipoIva> tipoIvas = tipoIvaLogica.ObtenerTiposIva();

            // Agrego un elemento vacío al principio de la lista
            tipoIvas.Insert(0, new TipoIva { IdTipoIva = 0, Descripcion = "Seleccionar" });

            // Asigna la lista de tipos de IVA al ComboBox
            cboTipoIva.DataSource = tipoIvas;
            cboTipoIva.DisplayMember = "Descripcion"; // Muestro la descripción en el ComboBox
            cboTipoIva.ValueMember = "idTipoIva"; // Uso el IdTipoIva como valor seleccionado

            //cboOpcion.SelectedIndex = 0;
        }
        private void CargarClientesEnComboBox()
        {
            List<Cliente> clientes = clienteLogica.ObtenerClientes();

            // Agrego un elemento vacío al principio de la lista
            clientes.Insert(0, new Cliente { IdCliente = 0, RazonSocial = "Seleccionar" });

            // Asigna la lista de productos al ComboBox
            cboOpcion.DataSource = clientes;
            cboOpcion.DisplayMember = "RazonSocial"; // Muestro la descripción en el ComboBox
            cboOpcion.ValueMember = "IdCliente"; // Uso el Idcliente como valor seleccionado

            cboOpcion.SelectedIndex = 0;// Selecciona el elemento vacío por defecto
        }
        private void CargarDatosClienteSeleccionado()
        {
            // Verifico si hay un elemento seleccionado en el ComboBox
            if (cboOpcion.SelectedItem != null && cboOpcion.SelectedItem is Cliente cliente)
            {
                // Verifico si no es el elemento inicial ("Seleccionar")
                if (cliente.IdCliente != 0)
                {
                    // Cargo los datos del producto seleccionado 
                    txtOpcion1.Text = cliente.RazonSocial;
                    txtOpcion2.Text = cliente.LimiteCredito.ToString();
                    int idTipoIva = cliente.TipoIva;
                    string descripcionTipoIva = tipoIvaLogica.ObtenerDescripcionTipoIva(idTipoIva);
                    cboTipoIva.Text = descripcionTipoIva;
                    //dtpFechaAlta.Value = cliente.FechaAlta;
                    //dtpFechaBaja.Value = cliente.FechaAlta;
                }
                else
                {
                    // Si es el elemento Seleccionar, dejo los campos vacíos
                    txtOpcion1.Text = "";
                    txtOpcion2.Text = "";
                    txtOpcion3.Text = "";
                    chkHabilitado.Checked = false;
                }
            }
        }

    }



}
