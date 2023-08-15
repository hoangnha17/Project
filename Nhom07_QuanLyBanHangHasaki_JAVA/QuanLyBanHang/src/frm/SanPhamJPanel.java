/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package frm;

import Hasaki.Main;
import static Hasaki.Main.frmTC;
import java.awt.Color;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author LENOVO
 */
public class SanPhamJPanel extends javax.swing.JPanel {

    /**
     * Creates new form SanPhamJPanel
     */
    public SanPhamJPanel() {
        initComponents();
        LayDuLieuSanPham();
    }
public void LayDuLieuSanPham (){
    String cautruyvan = "";
        cautruyvan = "select * from MATHANG ";
        ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã mặt hàng", "Tên mặt hàng", "Đơn vị tính", "Số lượng tồn", "Giá nhập", "Giá bán","Mã loại hàng","Thành Phần","Xuất sứ"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblSanPham.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[10];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAMH");
                item[2] = rs.getString("TENMH");
                item[3] = rs.getString("DVT");
                item[4] = rs.getInt("SLTON");
                item[5] = rs.getString("DGNHAP");
                item[6] = rs.getString("DGBAN");
                item[7] = rs.getString("MALH");
                item[8] = rs.getString("THANHPHAN");
                item[9] = rs.getString("XUATXU");
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
 }
  public boolean KiemTraNhapSanPham(int ts) {
        boolean kiemtra = false;
         String MaMH,TenMH,DVT,SLTon,DGNhap,DGBan,MaLH,ThanhPhan,XuatXu;
        MaMH=txtMaMH.getText();
        TenMH=txtTenMH.getText();
        DVT=txtDVT.getText();
        SLTon=txtSLTon.getText();
        DGNhap=txtDGNhap.getText();
        DGBan=txtDGBan.getText();
        MaLH=txtMaLH.getText();
        ThanhPhan=txtThanhPhan.getText();
        XuatXu= txtXuatXu.getText();
        String  ThongBao = "";
        
        if (MaMH.equals("") && ts == 1) {
            ThongBao += "Bạn Chưa nhập mã mặt hàng\n";
            lblMaMH.setForeground(Color.red);
        }
        if (TenMH.equals("")) {
            ThongBao += "Bạn chưa nhập tên mặt hàng\n";
            lblTenMH.setForeground(Color.red);
            
        }
        if (DVT.equals("")) {
            ThongBao += "Bạn chưa nhập đơn vị tính\n";
            lblDVT.setForeground(Color.red);
        }
        if (SLTon.equals("")) {
            lblSLTon.setForeground(Color.red);
            ThongBao += "Bạn chưa nhập lượng tồn\n";
        }
        if (DGNhap.equals("")) {
            lblGiaNhap.setForeground(Color.red);
            ThongBao += "Bạn chưa nhập giá nhập \n";
           
        }
        if (DGBan.equals("")) {
            ThongBao += "Bạn chưa nhập giá bán\n";
            lblGiaBan.setForeground(Color.red);
        }
        if (MaLH.equals("")) {
            ThongBao += "Bạn chưa nhập Mã loại hàng\n";
            lblMaLH.setForeground(Color.red);
        }
        
        if (XuatXu.equals("")) {
            ThongBao += "Bạn chưa nhập Xuất sứ\n";
            lblXuatxu.setForeground(Color.red);
        }
        if (ThongBao.equals("")) {
            kiemtra = true;
            lblMaMH.setForeground(Color.black);
            lblTenMH.setForeground(Color.black);
            lblDVT.setForeground(Color.black);
            lblGiaBan.setForeground(Color.black);
            lblGiaNhap.setForeground(Color.black);
            lblMaLH.setForeground(Color.black);
            lblXuatxu.setForeground(Color.black);
        } else {
            kiemtra = false;
            frmTC.ThongBao(ThongBao, "LỖI NHẬP LIỆU", 2);
        }
        return kiemtra;
    }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jPanel1 = new javax.swing.JPanel();
        lblMaMH = new javax.swing.JLabel();
        lblTenMH = new javax.swing.JLabel();
        lblDVT = new javax.swing.JLabel();
        lblSLTon = new javax.swing.JLabel();
        lblGiaNhap = new javax.swing.JLabel();
        lblGiaBan = new javax.swing.JLabel();
        lblMaLH = new javax.swing.JLabel();
        lblThanhPhan = new javax.swing.JLabel();
        lblXuatxu = new javax.swing.JLabel();
        txtMaMH = new javax.swing.JTextField();
        txtTenMH = new javax.swing.JTextField();
        txtDVT = new javax.swing.JTextField();
        txtSLTon = new javax.swing.JTextField();
        txtDGNhap = new javax.swing.JTextField();
        txtDGBan = new javax.swing.JTextField();
        txtMaLH = new javax.swing.JTextField();
        txtThanhPhan = new javax.swing.JTextField();
        txtXuatXu = new javax.swing.JTextField();
        jPanel3 = new javax.swing.JPanel();
        jLabel11 = new javax.swing.JLabel();
        RadDGBan = new javax.swing.JRadioButton();
        RadXuatXu = new javax.swing.JRadioButton();
        btnSapXep = new javax.swing.JButton();
        btnThem = new javax.swing.JButton();
        btnSua = new javax.swing.JButton();
        btnXoa = new javax.swing.JButton();
        btnReset = new javax.swing.JButton();
        jPanel2 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        btnTimMH = new javax.swing.JButton();
        RadMaMH = new javax.swing.JRadioButton();
        RadTop = new javax.swing.JRadioButton();
        txtTimMH = new javax.swing.JTextField();
        jScrollPane1 = new javax.swing.JScrollPane();
        tblSanPham = new javax.swing.JTable();

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 102, 0));
        jLabel1.setText("DANH MỤC SẢN PHẨM ");

        lblMaMH.setText("Mã Mặt Hàng");

        lblTenMH.setText("Tên mặt hàng");

        lblDVT.setText("Đơn vị tính");

        lblSLTon.setText("Số lượng tồn");

        lblGiaNhap.setText("Giá nhập");

        lblGiaBan.setText("Giá bán");

        lblMaLH.setText("Mã Loại");

        lblThanhPhan.setText("Thành phần");

        lblXuatxu.setText("Xuất sứ");

        jPanel3.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        jLabel11.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        jLabel11.setForeground(new java.awt.Color(0, 102, 0));
        jLabel11.setText("Sắp xếp");

        RadDGBan.setForeground(new java.awt.Color(0, 102, 0));
        RadDGBan.setText("Giá bán tăng dần");

        RadXuatXu.setForeground(new java.awt.Color(0, 102, 0));
        RadXuatXu.setText("Xuất sứ");

        btnSapXep.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnSapXep.setForeground(new java.awt.Color(0, 102, 0));
        btnSapXep.setText("OK");
        btnSapXep.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSapXepActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addGap(81, 81, 81)
                        .addComponent(jLabel11))
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(RadXuatXu)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(RadDGBan)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(btnSapXep)
                .addGap(23, 23, 23))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jLabel11)
                        .addGap(18, 18, 18)
                        .addComponent(RadDGBan))
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addGap(64, 64, 64)
                        .addComponent(btnSapXep)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(RadXuatXu)
                .addContainerGap(38, Short.MAX_VALUE))
        );

        btnThem.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnThem.setForeground(new java.awt.Color(0, 102, 51));
        btnThem.setText("Thêm");
        btnThem.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnThemActionPerformed(evt);
            }
        });

        btnSua.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnSua.setForeground(new java.awt.Color(0, 102, 0));
        btnSua.setText("Sửa");
        btnSua.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnSuaActionPerformed(evt);
            }
        });

        btnXoa.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnXoa.setForeground(new java.awt.Color(0, 102, 0));
        btnXoa.setText("Xóa");
        btnXoa.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnXoaActionPerformed(evt);
            }
        });

        btnReset.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnReset.setForeground(new java.awt.Color(0, 102, 0));
        btnReset.setText("Reset");
        btnReset.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnResetActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(56, 56, 56)
                        .addComponent(btnThem)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnSua))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGap(41, 41, 41)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(lblSLTon)
                            .addComponent(lblTenMH, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(lblMaMH)
                            .addComponent(lblDVT, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addGap(18, 18, 18)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtTenMH, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(txtDVT)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(txtMaMH, javax.swing.GroupLayout.PREFERRED_SIZE, 146, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(0, 0, Short.MAX_VALUE))
                            .addComponent(txtSLTon))))
                .addGap(18, 18, 18)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblGiaNhap)
                    .addComponent(lblGiaBan)
                    .addComponent(lblMaLH)
                    .addComponent(lblThanhPhan))
                .addGap(7, 7, 7)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(txtMaLH)
                            .addComponent(txtDGBan, javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(txtDGNhap, javax.swing.GroupLayout.PREFERRED_SIZE, 128, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(0, 0, Short.MAX_VALUE))
                            .addComponent(txtThanhPhan))
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 30, Short.MAX_VALUE)
                                .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addGap(40, 40, 40)
                                .addComponent(lblXuatxu)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(txtXuatXu))))
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(btnXoa)
                        .addGap(69, 69, 69)
                        .addComponent(btnReset)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(24, 24, 24)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblMaMH)
                    .addComponent(lblGiaNhap)
                    .addComponent(lblXuatxu)
                    .addComponent(txtMaMH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtDGNhap, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtXuatXu, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(27, 27, 27)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblTenMH)
                            .addComponent(lblGiaBan)
                            .addComponent(txtTenMH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtDGBan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(34, 34, 34)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblDVT)
                            .addComponent(lblMaLH)
                            .addComponent(txtDVT, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtMaLH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(39, 39, 39)
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(lblSLTon)
                            .addComponent(lblThanhPhan)
                            .addComponent(txtSLTon, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(txtThanhPhan, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 22, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnThem)
                    .addComponent(btnSua)
                    .addComponent(btnXoa)
                    .addComponent(btnReset))
                .addGap(22, 22, 22))
        );

        jPanel2.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(0, 102, 0));
        jLabel2.setText("Tìm Kiếm");

        btnTimMH.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnTimMH.setForeground(new java.awt.Color(0, 102, 0));
        btnTimMH.setText("Tìm");
        btnTimMH.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnTimMHActionPerformed(evt);
            }
        });

        RadMaMH.setForeground(new java.awt.Color(0, 102, 0));
        RadMaMH.setText("Mã mặt hàng");

        RadTop.setForeground(new java.awt.Color(0, 102, 0));
        RadTop.setText("Top 3 mặt hàng có lượng tồn cao nhất");

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(106, 106, 106)
                        .addComponent(jLabel2))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(19, 19, 19)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(RadTop)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addComponent(RadMaMH)
                                .addGap(18, 18, 18)
                                .addComponent(txtTimMH, javax.swing.GroupLayout.PREFERRED_SIZE, 108, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(108, 108, 108)
                        .addComponent(btnTimMH)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel2)
                .addGap(18, 18, 18)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(RadMaMH)
                    .addComponent(txtTimMH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(29, 29, 29)
                .addComponent(RadTop)
                .addGap(32, 32, 32)
                .addComponent(btnTimMH)
                .addContainerGap(46, Short.MAX_VALUE))
        );

        tblSanPham.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        tblSanPham.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null, null, null}
            },
            new String [] {
                "Mã Mặt Hàng", "Tên Mặt Hàng", "Đơn vị tính", "Số lượng tồn", "Giá nhập", "Giá bán", "Mã Loại Hàng", "Thành Phần", "Xuất sứ"
            }
        ));
        tblSanPham.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblSanPhamMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tblSanPham);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(445, 445, 445)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 236, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(67, 67, 67)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jScrollPane1)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addGap(6, 6, 6)))
                .addGap(44, 44, 44))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 242, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(28, 28, 28)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(31, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents

    private void tblSanPhamMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblSanPhamMouseClicked
        // TODO add your handling code here:
          int viTriDongVuaBam = tblSanPham.getSelectedRow();
        txtMaMH.setText(tblSanPham.getValueAt(viTriDongVuaBam, 1).toString());
        txtTenMH.setText(tblSanPham.getValueAt(viTriDongVuaBam, 2).toString());
        txtDVT.setText(tblSanPham.getValueAt(viTriDongVuaBam, 3).toString());
        txtSLTon.setText(tblSanPham.getValueAt(viTriDongVuaBam, 4).toString());
        txtDGNhap.setText(tblSanPham.getValueAt(viTriDongVuaBam, 5).toString());
        txtDGBan.setText(tblSanPham.getValueAt(viTriDongVuaBam, 6).toString());
        txtMaLH.setText(tblSanPham.getValueAt(viTriDongVuaBam, 7).toString());
        txtThanhPhan.setText(tblSanPham.getValueAt(viTriDongVuaBam, 8).toString());
        txtXuatXu.setText(tblSanPham.getValueAt(viTriDongVuaBam, 9).toString());
    }//GEN-LAST:event_tblSanPhamMouseClicked

    private void btnThemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnThemActionPerformed
        // TODO add your handling code here:
          String MaMH,TenMH,DVT,SLTon,DGNhap,DGBan,MaLH,ThanhPhan,XuatXu;
        MaMH=txtMaMH.getText();
        TenMH=txtTenMH.getText();
        DVT=txtDVT.getText();
        SLTon=txtSLTon.getText();
        DGNhap=txtDGNhap.getText();
        DGBan=txtDGBan.getText();
        MaLH=txtMaLH.getText();
        ThanhPhan=txtThanhPhan.getText();
        XuatXu= txtXuatXu.getText();
        String cautruyvan = "INSERT into MATHANG(MAMH,TENMH,DVT,SLTON,DGNHAP,DGBAN,MALH,THANHPHAN,XUATXU) Values('" + MaMH + "',N'" + TenMH + "',N'" + DVT + "','" + SLTon + "','" + DGNhap + "','" + DGBan + "','" + MaLH + "',N'" + ThanhPhan + "',N'" + XuatXu + "')";
        
        boolean kiemtra = KiemTraNhapSanPham(0);
        if (kiemtra) {
            Main.connection.ExcuteQueryUpdateDB(cautruyvan);
            Main.frmTC.infoBox("Thêm Thành Công !!!", "Thông báo");
            System.out.println("Đã Thêm Thành Công");
            System.out.println(cautruyvan);
        } else {
            System.out.println("Thất Bại");
        }
        LayDuLieuSanPham();
    }//GEN-LAST:event_btnThemActionPerformed

    private void btnSuaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSuaActionPerformed
        // TODO add your handling code here:
          String MaMH,TenMH,DVT,SLTon,DGNhap,DGBan,MaLH,ThanhPhan,XuatXu;
        MaMH=txtMaMH.getText();
        TenMH=txtTenMH.getText();
        DVT=txtDVT.getText();
        SLTon=txtSLTon.getText();
        DGNhap=txtDGNhap.getText();
        DGBan=txtDGBan.getText();
        MaLH=txtMaLH.getText();
        ThanhPhan=txtThanhPhan.getText();
        XuatXu= txtXuatXu.getText();
          String cautruyvan = "update MATHANG set TENMH = N'" + TenMH + "',DVT=N'" + DVT + "',SLTON='" + SLTon + "',DGNHAP='" + DGNhap + "',DGBAN='" + DGBan + "',MALH='" + MaLH + "',THANHPHAN=N'" + ThanhPhan + "',XUATXU=N'" + XuatXu + "'WHERE MAMH='" + MaMH + "';";
        boolean kiemtra = KiemTraNhapSanPham(0);
        if (kiemtra) {
            Main.connection.ExcuteQueryUpdateDB(cautruyvan);
            Main.frmTC.infoBox("Sửa Thành Công !!!", "Thông báo");
            System.out.println("Đã Sửa Thành Công");
            System.out.println(cautruyvan);
        } else {
            System.out.println("Thất Bại");
        }
        LayDuLieuSanPham();
    }//GEN-LAST:event_btnSuaActionPerformed

    private void btnXoaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnXoaActionPerformed
        // TODO add your handling code here:
         String MaMH = txtMaMH.getText();
        String cautruyvan = "delete MATHANG where MAMH='" + MaMH+"';";
         Main.frmTC.infoBox("Lỗi xóa Sản Phẩm !!!", "Thông báo");
         boolean kiemtra = KiemTraNhapSanPham(0);
        if (kiemtra) {
            Main.connection.ExcuteQueryUpdateDB(cautruyvan);
            System.out.println("Đã Xóa Thành Công");
          //  Main.frmTC.infoBox("Xóa Thành Công !!!", "Thông báo");
            System.out.println(cautruyvan);
        } else {
            System.out.println("Thất Bại");
        }
        LayDuLieuSanPham();
    }//GEN-LAST:event_btnXoaActionPerformed

    private void btnResetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnResetActionPerformed
        // TODO add your handling code here:
        txtMaMH.setText("");
        txtTenMH.setText("");
       txtDVT.setText("");
        txtSLTon.setText("");
      txtDGNhap.setText("");
        txtDGBan.setText("");
       txtMaLH.setText("");
        txtThanhPhan.setText("");
         txtXuatXu.setText("");
         LayDuLieuSanPham();
          Main.frmTC.infoBox("Reset Thành Công !!!", "Thông báo");
    }//GEN-LAST:event_btnResetActionPerformed

    private void btnSapXepActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSapXepActionPerformed
        // TODO add your handling code here:
        if(RadDGBan.isSelected())
        {
            String cautruyvan="Select * from MATHANG ORDER BY DGBAN ASC";
            
         ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã mặt hàng", "Tên mặt hàng", "Đơn vị tính", "Số lượng tồn", "Giá nhập", "Giá bán","Mã loại hàng","Thành Phần","Xuất sứ"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblSanPham.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[10];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAMH");
                item[2] = rs.getString("TENMH");
                item[3] = rs.getString("DVT");
                item[4] = rs.getInt("SLTON");
                item[5] = rs.getString("DGNHAP");
                item[6] = rs.getString("DGBAN");
                item[7] = rs.getString("MALH");
                item[8] = rs.getString("THANHPHAN");
                item[9] = rs.getString("XUATXU");
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
        }else if (RadXuatXu.isSelected())
        {
             String cautruyvan="Select * from MATHANG ORDER BY XUATXU DESC";
            
         ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã mặt hàng", "Tên mặt hàng", "Đơn vị tính", "Số lượng tồn", "Giá nhập", "Giá bán","Mã loại hàng","Thành Phần","Xuất sứ"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblSanPham.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[10];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAMH");
                item[2] = rs.getString("TENMH");
                item[3] = rs.getString("DVT");
                item[4] = rs.getInt("SLTON");
                item[5] = rs.getString("DGNHAP");
                item[6] = rs.getString("DGBAN");
                item[7] = rs.getString("MALH");
                item[8] = rs.getString("THANHPHAN");
                item[9] = rs.getString("XUATXU");
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
        }
    }//GEN-LAST:event_btnSapXepActionPerformed

    private void btnTimMHActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnTimMHActionPerformed
        // TODO add your handling code here:
        if(RadMaMH.isSelected())
        {
             String cautruyvan="Select * from MATHANG where MAMH='"+txtTimMH.getText()+"'" ;
            
         ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã mặt hàng", "Tên mặt hàng", "Đơn vị tính", "Số lượng tồn", "Giá nhập", "Giá bán","Mã loại hàng","Thành Phần","Xuất sứ"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblSanPham.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[10];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAMH");
                item[2] = rs.getString("TENMH");
                item[3] = rs.getString("DVT");
                item[4] = rs.getInt("SLTON");
                item[5] = rs.getString("DGNHAP");
                item[6] = rs.getString("DGBAN");
                item[7] = rs.getString("MALH");
                item[8] = rs.getString("THANHPHAN");
                item[9] = rs.getString("XUATXU");
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
       
        } else if (RadTop.isSelected()){
             String cautruyvan="Select top(3) * from MATHANG ORDER BY SLTON DESC";
            
         ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã mặt hàng", "Tên mặt hàng", "Đơn vị tính", "Số lượng tồn", "Giá nhập", "Giá bán","Mã loại hàng","Thành Phần","Xuất sứ"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblSanPham.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[10];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAMH");
                item[2] = rs.getString("TENMH");
                item[3] = rs.getString("DVT");
                item[4] = rs.getInt("SLTON");
                item[5] = rs.getString("DGNHAP");
                item[6] = rs.getString("DGBAN");
                item[7] = rs.getString("MALH");
                item[8] = rs.getString("THANHPHAN");
                item[9] = rs.getString("XUATXU");
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
        }
    }//GEN-LAST:event_btnTimMHActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JRadioButton RadDGBan;
    private javax.swing.JRadioButton RadMaMH;
    private javax.swing.JRadioButton RadTop;
    private javax.swing.JRadioButton RadXuatXu;
    private javax.swing.JButton btnReset;
    private javax.swing.JButton btnSapXep;
    private javax.swing.JButton btnSua;
    private javax.swing.JButton btnThem;
    private javax.swing.JButton btnTimMH;
    private javax.swing.JButton btnXoa;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblDVT;
    private javax.swing.JLabel lblGiaBan;
    private javax.swing.JLabel lblGiaNhap;
    private javax.swing.JLabel lblMaLH;
    private javax.swing.JLabel lblMaMH;
    private javax.swing.JLabel lblSLTon;
    private javax.swing.JLabel lblTenMH;
    private javax.swing.JLabel lblThanhPhan;
    private javax.swing.JLabel lblXuatxu;
    private javax.swing.JTable tblSanPham;
    private javax.swing.JTextField txtDGBan;
    private javax.swing.JTextField txtDGNhap;
    private javax.swing.JTextField txtDVT;
    private javax.swing.JTextField txtMaLH;
    private javax.swing.JTextField txtMaMH;
    private javax.swing.JTextField txtSLTon;
    private javax.swing.JTextField txtTenMH;
    private javax.swing.JTextField txtThanhPhan;
    private javax.swing.JTextField txtTimMH;
    private javax.swing.JTextField txtXuatXu;
    // End of variables declaration//GEN-END:variables
}