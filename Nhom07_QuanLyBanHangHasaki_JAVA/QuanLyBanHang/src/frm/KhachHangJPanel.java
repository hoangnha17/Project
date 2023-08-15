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
public class KhachHangJPanel extends javax.swing.JPanel {

    /**
     * Creates new form KhachHangJPanel
     */
    public KhachHangJPanel() {
        initComponents();
        LayDuLieuKhachHang();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        tblKhachHang_KhachHang = new javax.swing.JTable();
        jPanel2 = new javax.swing.JPanel();
        lblMaKH = new javax.swing.JLabel();
        lblHoKH = new javax.swing.JLabel();
        lblTenKH = new javax.swing.JLabel();
        lblGioiTinhKH = new javax.swing.JLabel();
        lblDiaChiKH = new javax.swing.JLabel();
        lblDienThoaiKH = new javax.swing.JLabel();
        lblEmailKH = new javax.swing.JLabel();
        txtMaKH = new javax.swing.JTextField();
        txtTenKH = new javax.swing.JTextField();
        txtDiaChiKH = new javax.swing.JTextField();
        txtEmailKH = new javax.swing.JTextField();
        txtHoKH = new javax.swing.JTextField();
        txtDienThoaiKH = new javax.swing.JTextField();
        txtGioiTinhKH = new javax.swing.JTextField();
        btnThem = new javax.swing.JButton();
        btnSua = new javax.swing.JButton();
        btnXoa = new javax.swing.JButton();
        btnReset = new javax.swing.JButton();
        jPanel3 = new javax.swing.JPanel();
        jLabel9 = new javax.swing.JLabel();
        RadMaKH = new javax.swing.JRadioButton();
        RadTenKH = new javax.swing.JRadioButton();
        txtTimKiemKH = new javax.swing.JTextField();
        btnTimKH = new javax.swing.JButton();

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(0, 102, 0));
        jLabel1.setText("DANH SÁCH KHÁCH HÀNG");

        tblKhachHang_KhachHang.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        tblKhachHang_KhachHang.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null},
                {null, null, null, null, null, null, null}
            },
            new String [] {
                "Mã Khách Hàng", "Họ Khách Hàng", "Tên Khách Hàng", "Giới Tính", "Địa Chỉ", "Điện Thoai", "Email"
            }
        ));
        tblKhachHang_KhachHang.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tblKhachHang_KhachHangMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(tblKhachHang_KhachHang);

        lblMaKH.setText("Mã Khách Hàng");

        lblHoKH.setText("Họ Khách Hàng");

        lblTenKH.setText("Tên Khách Hàng");

        lblGioiTinhKH.setText("Giới Tính ");

        lblDiaChiKH.setText("Địa Chỉ");

        lblDienThoaiKH.setText("Điện Thoại");

        lblEmailKH.setText("Email ");

        btnThem.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        btnThem.setForeground(new java.awt.Color(0, 102, 0));
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
        btnXoa.setForeground(new java.awt.Color(0, 102, 51));
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

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(81, 81, 81)
                        .addComponent(btnThem)
                        .addGap(96, 96, 96)
                        .addComponent(btnSua)
                        .addGap(125, 125, 125)
                        .addComponent(btnXoa)
                        .addGap(103, 103, 103)
                        .addComponent(btnReset))
                    .addGroup(jPanel2Layout.createSequentialGroup()
                        .addGap(35, 35, 35)
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(lblTenKH)
                            .addComponent(lblGioiTinhKH)
                            .addComponent(lblHoKH)
                            .addComponent(lblMaKH, javax.swing.GroupLayout.Alignment.TRAILING))
                        .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addGap(13, 13, 13)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                                    .addGroup(jPanel2Layout.createSequentialGroup()
                                        .addComponent(txtHoKH, javax.swing.GroupLayout.PREFERRED_SIZE, 178, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(221, 221, 221))
                                    .addGroup(jPanel2Layout.createSequentialGroup()
                                        .addComponent(txtMaKH, javax.swing.GroupLayout.PREFERRED_SIZE, 176, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                        .addComponent(lblDiaChiKH, javax.swing.GroupLayout.PREFERRED_SIZE, 83, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addGap(29, 29, 29)))
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(txtDienThoaiKH, javax.swing.GroupLayout.PREFERRED_SIZE, 243, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(txtDiaChiKH, javax.swing.GroupLayout.PREFERRED_SIZE, 243, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addGap(0, 0, Short.MAX_VALUE))
                            .addGroup(jPanel2Layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                    .addComponent(txtTenKH, javax.swing.GroupLayout.PREFERRED_SIZE, 177, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addComponent(txtGioiTinhKH, javax.swing.GroupLayout.PREFERRED_SIZE, 177, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(lblDienThoaiKH)
                                    .addComponent(lblEmailKH))
                                .addGap(50, 50, 50)
                                .addComponent(txtEmailKH, javax.swing.GroupLayout.PREFERRED_SIZE, 243, javax.swing.GroupLayout.PREFERRED_SIZE)))))
                .addContainerGap(38, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addGap(44, 44, 44)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtMaKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblMaKH)
                    .addComponent(txtDiaChiKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(lblDiaChiKH, javax.swing.GroupLayout.PREFERRED_SIZE, 26, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(31, 31, 31)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(lblHoKH)
                    .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(txtHoKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(lblDienThoaiKH)
                        .addComponent(txtDienThoaiKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(24, 24, 24)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblTenKH)
                    .addComponent(lblEmailKH)
                    .addComponent(txtTenKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(txtEmailKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(29, 29, 29)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblGioiTinhKH)
                    .addComponent(txtGioiTinhKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 41, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnThem)
                    .addComponent(btnSua)
                    .addComponent(btnXoa)
                    .addComponent(btnReset))
                .addGap(32, 32, 32))
        );

        jPanel3.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));

        jLabel9.setFont(new java.awt.Font("Tahoma", 1, 13)); // NOI18N
        jLabel9.setForeground(new java.awt.Color(0, 153, 0));
        jLabel9.setText("Tìm Kiếm");

        RadMaKH.setForeground(new java.awt.Color(0, 153, 0));
        RadMaKH.setText("Mã Khách Hàng");

        RadTenKH.setForeground(new java.awt.Color(0, 153, 0));
        RadTenKH.setText("Tên Khách Hàng");

        btnTimKH.setText("Tìm");
        btnTimKH.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnTimKHActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel3Layout = new javax.swing.GroupLayout(jPanel3);
        jPanel3.setLayout(jPanel3Layout);
        jPanel3Layout.setHorizontalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel3Layout.createSequentialGroup()
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(RadMaKH)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(RadTenKH, javax.swing.GroupLayout.PREFERRED_SIZE, 121, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jPanel3Layout.createSequentialGroup()
                        .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(jPanel3Layout.createSequentialGroup()
                                .addGap(96, 96, 96)
                                .addComponent(jLabel9))
                            .addGroup(jPanel3Layout.createSequentialGroup()
                                .addGap(60, 60, 60)
                                .addComponent(txtTimKiemKH, javax.swing.GroupLayout.PREFERRED_SIZE, 122, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addGap(98, 98, 98)
                .addComponent(btnTimKH)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel3Layout.setVerticalGroup(
            jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel3Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel9)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(txtTimKiemKH, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(32, 32, 32)
                .addGroup(jPanel3Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(RadMaKH)
                    .addComponent(RadTenKH))
                .addGap(18, 18, 18)
                .addComponent(btnTimKH)
                .addGap(31, 31, 31))
        );

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(jPanel1Layout.createSequentialGroup()
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jPanel3, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 1075, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap())
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(424, 424, 424)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 294, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addGap(18, 18, 18)
                .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 61, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.DEFAULT_SIZE, 166, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(jPanel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(115, 115, 115))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(24, 24, 24))))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 18, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
    }// </editor-fold>//GEN-END:initComponents

    public void LayDuLieuKhachHang(){
    String cautruyvan = "";
        cautruyvan = "select * from KHACHHANG ";
        ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã Khách Hàng", "Họ Khách Hàng", "Tên Khách Hàng", "Giới tính", "Địa Chỉ","Điện Thoại","Email"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblKhachHang_KhachHang.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[8];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAKH");
                item[2] = rs.getString("HOKH");
                item[3] = rs.getString("TENKH");
                item[4] = rs.getString("GIOITINHKH");
               
                item[5] = rs.getString("DIACHIKH");
                item[6] = rs.getString("DIENTHOAIKH");
                item[7] = rs.getString("EMAILKH");
            
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
 }
    public boolean KiemTraNhapNhanVien(int ts) {
        boolean kiemtra = false;
         String MaKH,HoKH,TenKH,GioiTinhKH,DiaChiKH ,DienThoaiKH,EmailKH;
        MaKH=txtMaKH.getText();
        HoKH=txtHoKH.getText();
        TenKH=txtTenKH.getText();
        GioiTinhKH=txtGioiTinhKH.getText();
       
        DiaChiKH=txtDiaChiKH.getText();
        DienThoaiKH=txtDienThoaiKH.getText();
        EmailKH=txtEmailKH.getText();
     
        String  ThongBao = "";
        
        if (MaKH.equals("") && ts == 1) {
            ThongBao += "Bạn Chưa Nhập Khách Hàng Để Lấy  Mã Khách Hàng\n";
            lblMaKH.setForeground(Color.red);
        }
        if (HoKH.equals("")) {
            ThongBao += "Bạn chưa Nhập họ khách hàng\n";
            lblHoKH.setForeground(Color.red);
            
        }
        if (TenKH.equals("")) {
            ThongBao += "Bạn chưa Nhập tên khách hàng\n";
            lblTenKH.setForeground(Color.red);
        }
        if (GioiTinhKH.equals("")) {
            lblGioiTinhKH.setForeground(Color.red);
            ThongBao += "Bạn chưa Nhập giới tính khách hàng\n";
        }
        
        if (DiaChiKH.equals("")) {
            ThongBao += "Bạn chưa Nhập địa chỉ khách hàng\n";
            lblDiaChiKH.setForeground(Color.red);
        }
        if (DienThoaiKH.equals("")) {
            ThongBao += "Bạn chưa Nhập sdt khách hàng\n";
            lblDienThoaiKH.setForeground(Color.red);
        }
        if (EmailKH.equals("")) {
            ThongBao += "Bạn chưa Nhập Email khach hang \n";
            lblEmailKH.setForeground(Color.red);
        }
       
        
        if (ThongBao.equals("")) {
            kiemtra = true;
            lblMaKH.setForeground(Color.black);
            lblHoKH.setForeground(Color.black);
            lblTenKH.setForeground(Color.black);
            lblGioiTinhKH.setForeground(Color.black);
       
            lblDiaChiKH.setForeground(Color.black);
             lblDienThoaiKH.setForeground(Color.black);
             lblEmailKH.setForeground(Color.black);
      
        } else {
            kiemtra = false;
            frmTC.ThongBao(ThongBao, "LỖI NHẬP LIỆU", 2);
        }
        return kiemtra;
    }
    private void tblKhachHang_KhachHangMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tblKhachHang_KhachHangMouseClicked
        // TODO add your handling code here:
        int viTriDongVuaBam = tblKhachHang_KhachHang.getSelectedRow();
        txtMaKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 1).toString());
        txtHoKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 2).toString());
        txtTenKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 3).toString());
        txtGioiTinhKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 4).toString());
        txtDiaChiKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 5).toString());
        txtDienThoaiKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 6).toString());
        txtEmailKH.setText(tblKhachHang_KhachHang.getValueAt(viTriDongVuaBam, 7).toString());
      ;

    }//GEN-LAST:event_tblKhachHang_KhachHangMouseClicked

    private void btnSuaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnSuaActionPerformed
        // TODO add your handling code here:
         String MaKH,HoKH,TenKH,GioiTinhKH,DiaChiKH ,DienThoaiKH,EmailKH;
        MaKH=txtMaKH.getText();
        HoKH=txtHoKH.getText();
        TenKH=txtTenKH.getText();
        GioiTinhKH=txtGioiTinhKH.getText();
       
        DiaChiKH=txtDiaChiKH.getText();
        DienThoaiKH=txtDienThoaiKH.getText();
        EmailKH=txtEmailKH.getText();
        String cautruyvan = "update KHACHHANG set TENKH = N'" + TenKH +
                "',HONV=N'" + HoKH + "',DIENTHOAINV='" + DienThoaiKH + "',DIACHINV=N'" + DiaChiKH+"',EMAILNV='" + EmailKH + "',GIOITINHNV=N'" + GioiTinhKH + "' WHERE MANV='" + MaKH + "';";
        boolean kiemtra = KiemTraNhapNhanVien(0);
        if (kiemtra) {
            Main.connection.ExcuteQueryUpdateDB(cautruyvan);
            Main.frmTC.infoBox("Sửa Thành Công !!!", "Thông báo");
            System.out.println("Đã Sửa Thành Công");
            System.out.println(cautruyvan);
        } else {
            System.out.println("Thất Bại");
        }
        LayDuLieuKhachHang();
    }//GEN-LAST:event_btnSuaActionPerformed

    private void btnThemActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnThemActionPerformed
        // TODO add your handling code here:
         String MaKH,HoKH,TenKH,GioiTinhKH,DiaChiKH ,DienThoaiKH,EmailKH;
        MaKH=txtMaKH.getText();
        HoKH=txtHoKH.getText();
        TenKH=txtTenKH.getText();
        GioiTinhKH=txtGioiTinhKH.getText();
       
        DiaChiKH=txtDiaChiKH.getText();
        DienThoaiKH=txtDienThoaiKH.getText();
        EmailKH=txtEmailKH.getText();
        String cautruyvan = "INSERT into KHACHHANG(MAKH,HOKH,TENKH,GIOITINHKH,DIACHIKH,DIENTHOAIKH,EMAILKH) Values('" + MaKH + "',N'" + HoKH + "',N'" + TenKH + "',N'" + GioiTinhKH + "',N'" + DiaChiKH + "','" + DienThoaiKH + "','" + EmailKH + "')";
        
        boolean kiemtra = KiemTraNhapNhanVien(0);
        if (kiemtra) {
            Main.connection.ExcuteQueryUpdateDB(cautruyvan);
            Main.frmTC.infoBox("Thêm Thành Công !!!", "Thông báo");
            System.out.println("Đã Thêm Thành Công");
            System.out.println(cautruyvan);
        } else {
            System.out.println("Thất Bại");
        }
         LayDuLieuKhachHang();
    }//GEN-LAST:event_btnThemActionPerformed

    private void btnXoaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnXoaActionPerformed
        // TODO add your handling code here:
        String MaKH = txtMaKH.getText();
        String cautruyvan = "delete KHACHHANG where MAKH='" + MaKH+"';";
       Main.frmTC.infoBox("Lỗi xóa khách hàng !!!", "Thông báo");
         boolean kiemtra = KiemTraNhapNhanVien(0);
        if (kiemtra) {
            Main.connection.ExcuteQueryUpdateDB(cautruyvan);
            System.out.println("Đã Xóa Thành Công");
            //Main.frmTC.infoBox("Xóa Thành Công !!!", "Thông báo");
            System.out.println(cautruyvan);
        } else {
            System.out.println("Thất Bại");
        }
         LayDuLieuKhachHang();
    }//GEN-LAST:event_btnXoaActionPerformed

    private void btnResetActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnResetActionPerformed
        // TODO add your handling code here:
         txtMaKH.setText("");
        txtHoKH.setText("");
        txtTenKH.setText("");
        txtGioiTinhKH.setText("");
        txtDiaChiKH.setText("");
        txtDienThoaiKH.setText("");
        txtEmailKH.setText("");
        LayDuLieuKhachHang();
        Main.frmTC.infoBox("Reset Thành Công !!!", "Thông báo");
    }//GEN-LAST:event_btnResetActionPerformed

    private void btnTimKHActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnTimKHActionPerformed
        // TODO add your handling code here:
         String Tim = "";
        if (RadMaKH.isSelected())
        {
            Tim= txtTimKiemKH.getText();
            String cautruyvan = "";
             cautruyvan = "select * from KHACHHANG where MAKH= '" +Tim+"'";
         ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã Khách Hàng", "Họ Khách Hàng", "Tên Khách Hàng", "Giới tính", "Địa Chỉ","Điện Thoại","Email"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblKhachHang_KhachHang.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[8];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAKH");
                item[2] = rs.getString("HOKH");
                item[3] = rs.getString("TENKH");
                item[4] = rs.getString("GIOITINHKH");
               
                item[5] = rs.getString("DIACHIKH");
                item[6] = rs.getString("DIENTHOAIKH");
                item[7] = rs.getString("EMAILKH");
            
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
            
        } else if (RadTenKH.isSelected()){

       String cautruyvan = "";
        cautruyvan = "select * from KHACHHANG where TENKH like N'"+txtTimKiemKH.getText().trim()+"'";
         
        ResultSet rs = Main.connection.ExcuteQueryGetTable(cautruyvan);
        Object[] obj = new Object[]{"STT", "Mã Khách Hàng", "Họ Khách Hàng", "Tên Khách Hàng", "Giới tính", "Địa Chỉ","Điện Thoại","Email"};
        DefaultTableModel tableModel = new DefaultTableModel(obj, 0);
        tblKhachHang_KhachHang.setModel(tableModel);
        int c = 0;
        try {
            while (rs.next()) {
                Object[] item = new Object[8];
                c++;
                item[0] = c;
                item[1] = rs.getString("MAKH");
                item[2] = rs.getString("HOKH");
                item[3] = rs.getString("TENKH");
                item[4] = rs.getString("GIOITINHKH");
               
                item[5] = rs.getString("DIACHIKH");
                item[6] = rs.getString("DIENTHOAIKH");
                item[7] = rs.getString("EMAILKH");
            
                tableModel.addRow(item);
            }
        } catch (SQLException ex) {
            System.out.println(ex.toString());
        }
        }
    }//GEN-LAST:event_btnTimKHActionPerformed


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JRadioButton RadMaKH;
    private javax.swing.JRadioButton RadTenKH;
    private javax.swing.JButton btnReset;
    private javax.swing.JButton btnSua;
    private javax.swing.JButton btnThem;
    private javax.swing.JButton btnTimKH;
    private javax.swing.JButton btnXoa;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JPanel jPanel3;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JLabel lblDiaChiKH;
    private javax.swing.JLabel lblDienThoaiKH;
    private javax.swing.JLabel lblEmailKH;
    private javax.swing.JLabel lblGioiTinhKH;
    private javax.swing.JLabel lblHoKH;
    private javax.swing.JLabel lblMaKH;
    private javax.swing.JLabel lblTenKH;
    private javax.swing.JTable tblKhachHang_KhachHang;
    private javax.swing.JTextField txtDiaChiKH;
    private javax.swing.JTextField txtDienThoaiKH;
    private javax.swing.JTextField txtEmailKH;
    private javax.swing.JTextField txtGioiTinhKH;
    private javax.swing.JTextField txtHoKH;
    private javax.swing.JTextField txtMaKH;
    private javax.swing.JTextField txtTenKH;
    private javax.swing.JTextField txtTimKiemKH;
    // End of variables declaration//GEN-END:variables
}
