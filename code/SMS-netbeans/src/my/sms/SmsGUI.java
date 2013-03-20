/*//GEN-FIRST:event_admBtnActionPerformed
 * To change this template, choose Tools | Templates//GEN-LAST:event_admBtnActionPerformed
 * and open the template in the editor.
 */
package my.sms;

import java.awt.*;
import javax.swing.*;
import javax.swing.JDialog;
import javax.swing.JOptionPane;
import java.awt.event.*;
import static java.awt.GraphicsDevice.WindowTranslucency.*;

/**
 *
 * @author ibm
 */
public class SmsGUI extends javax.swing.JFrame {

    /**
     * Creates new form SmsGUI
     */
    public SmsGUI() {
        super("SmsGUI");
        setLayout(new GridBagLayout());
        setSize(300,200);
        setLocationRelativeTo(null);
        setUndecorated(true);
        getContentPane().setBackground(Color.GRAY);
        initComponents();
   }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">                          
    private void initComponents() {
        
        jLabel1 = new javax.swing.JLabel();
        loginPanel = new javax.swing.JPanel();
        jLabel3 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jPasswordField1 = new javax.swing.JPasswordField();
        jButton1 = new javax.swing.JButton();
        logoPanel = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        activityPanel = new javax.swing.JPanel();
        stdtBtn = new javax.swing.JButton();
        fclBtn = new javax.swing.JButton();
        crsBtn = new javax.swing.JButton();
        exitBtn = new javax.swing.JButton();
        admBtn = new javax.swing.JButton();
        libBtn = new javax.swing.JButton();
        lveBtn = new javax.swing.JButton();
        accBtn = new javax.swing.JButton();

        java.util.ResourceBundle bundle = java.util.ResourceBundle.getBundle("my/sms/Bundle"); // NOI18N
        jLabel1.setText(bundle.getString("SmsGUI.jLabel1.text")); // NOI18N

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        loginPanel.setBackground(new java.awt.Color(204, 0, 204));
        loginPanel.setBorder(javax.swing.BorderFactory.createTitledBorder(bundle.getString("SmsGUI.loginPanel.border.title"))); // NOI18N

        jLabel3.setText(bundle.getString("SmsGUI.jLabel3.text")); // NOI18N

        jTextField1.setText(bundle.getString("SmsGUI.jTextField1.text")); // NOI18N
        jTextField1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField1ActionPerformed(evt);
            }
        });

        jLabel4.setText(bundle.getString("SmsGUI.jLabel4.text")); // NOI18N

        jPasswordField1.setText(bundle.getString("SmsGUI.jPasswordField1.text")); // NOI18N

        jButton1.setText(bundle.getString("SmsGUI.jButton1.text")); // NOI18N

        org.jdesktop.layout.GroupLayout loginPanelLayout = new org.jdesktop.layout.GroupLayout(loginPanel);
        loginPanel.setLayout(loginPanelLayout);
        loginPanelLayout.setHorizontalGroup(
            loginPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(loginPanelLayout.createSequentialGroup()
                .add(35, 35, 35)
                .add(loginPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING, false)
                    .add(jLabel3, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .add(jLabel4, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.UNRELATED)
                .add(loginPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING, false)
                    .add(jTextField1)
                    .add(jPasswordField1, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 149, Short.MAX_VALUE))
                .add(18, 18, 18)
                .add(jButton1, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 61, Short.MAX_VALUE)
                .addContainerGap())
        );
        loginPanelLayout.setVerticalGroup(
            loginPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(loginPanelLayout.createSequentialGroup()
                .add(loginPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(jTextField1, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(jLabel3))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.UNRELATED)
                .add(loginPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(jLabel4)
                    .add(jPasswordField1, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(jButton1, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 23, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))
                .add(0, 4, Short.MAX_VALUE))
        );

        logoPanel.setBackground(new java.awt.Color(255, 0, 51));
        logoPanel.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        logoPanel.setPreferredSize(new java.awt.Dimension(127, 54));

        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/my/sms/technicise.logo.png"))); // NOI18N
        jLabel2.setText(bundle.getString("SmsGUI.jLabel2.text")); // NOI18N
        jLabel2.setMaximumSize(new java.awt.Dimension(127, 54));

        org.jdesktop.layout.GroupLayout logoPanelLayout = new org.jdesktop.layout.GroupLayout(logoPanel);
        logoPanel.setLayout(logoPanelLayout);
        logoPanelLayout.setHorizontalGroup(
            logoPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(logoPanelLayout.createSequentialGroup()
                .add(jLabel2, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 126, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                .add(0, 0, Short.MAX_VALUE))
        );
        logoPanelLayout.setVerticalGroup(
            logoPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(jLabel2, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        stdtBtn.setText(bundle.getString("SmsGUI.stdtBtn.text")); // NOI18N
        stdtBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                stdtBtnActionPerformed(evt);
            }
        });

        fclBtn.setText(bundle.getString("SmsGUI.fclBtn.text")); // NOI18N
        fclBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                fclBtnActionPerformed(evt);
            }
        });

        crsBtn.setText(bundle.getString("SmsGUI.crsBtn.text")); // NOI18N
        crsBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                crsBtnActionPerformed(evt);
            }
        });

        exitBtn.setText(bundle.getString("SmsGUI.exitBtn.text")); // NOI18N
        exitBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                exitBtnActionPerformed(evt);
            }
        });

        admBtn.setText(bundle.getString("SmsGUI.admBtn.text")); // NOI18N
        admBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                admBtnActionPerformed(evt);
            }
        });

        libBtn.setText(bundle.getString("SmsGUI.libBtn.text")); // NOI18N
        libBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                libBtnActionPerformed(evt);
            }
        });

        lveBtn.setText(bundle.getString("SmsGUI.lveBtn.text")); // NOI18N
        lveBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                lveBtnActionPerformed(evt);
            }
        });

        accBtn.setText(bundle.getString("SmsGUI.accBtn.text")); // NOI18N
        accBtn.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                accBtnActionPerformed(evt);
            }
        });

        org.jdesktop.layout.GroupLayout activityPanelLayout = new org.jdesktop.layout.GroupLayout(activityPanel);
        activityPanel.setLayout(activityPanelLayout);
        activityPanelLayout.setHorizontalGroup(
            activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(activityPanelLayout.createSequentialGroup()
                .addContainerGap()
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
                    .add(activityPanelLayout.createSequentialGroup()
                        .add(libBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 99, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .add(accBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 99, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))
                    .add(activityPanelLayout.createSequentialGroup()
                        .add(admBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 99, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .add(lveBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 99, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))))
            .add(org.jdesktop.layout.GroupLayout.TRAILING, activityPanelLayout.createSequentialGroup()
                .add(121, 121, 121)
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.TRAILING)
                    .add(stdtBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 99, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(crsBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 99, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))
                .add(18, 18, Short.MAX_VALUE)
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING, false)
                    .add(exitBtn, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 99, Short.MAX_VALUE)
                    .add(fclBtn, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .add(111, 111, 111))
        );
        activityPanelLayout.setVerticalGroup(
            activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(activityPanelLayout.createSequentialGroup()
                .addContainerGap()
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(stdtBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(fclBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.UNRELATED)
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(admBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(lveBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))
                .add(18, 18, 18)
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(libBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(accBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .add(activityPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(crsBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(exitBtn, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, 40, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)))
        );

        org.jdesktop.layout.GroupLayout layout = new org.jdesktop.layout.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(org.jdesktop.layout.GroupLayout.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .add(layout.createParallelGroup(org.jdesktop.layout.GroupLayout.TRAILING)
                    .add(activityPanel, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .add(layout.createSequentialGroup()
                        .add(logoPanel, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED)
                        .add(loginPanel, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .add(4, 4, 4)))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(layout.createSequentialGroup()
                .addContainerGap()
                .add(layout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING, false)
                    .add(loginPanel, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .add(logoPanel, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 56, Short.MAX_VALUE))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED)
                .add(activityPanel, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>                        

    private void stdtBtnActionPerformed(java.awt.event.ActionEvent evt) {                                        
        // TODO add your handling code here:
        final JDialog bwin = new JDialog();
              
        StudentWindow stdWindow = new StudentWindow();
        
        bwin.add(stdWindow);
        bwin.pack();
        bwin.setVisible(true);
    }                                       

    private void crsBtnActionPerformed(java.awt.event.ActionEvent evt) {                                       
        // TODO add your handling code here:
        final JDialog bwin = new JDialog();
              
        CourseWindow crsWindow = new CourseWindow();
        
        bwin.add(crsWindow);
        bwin.pack();
        bwin.setVisible(true);
    }                                      

    private void exitBtnActionPerformed(java.awt.event.ActionEvent evt) {                                        
       System.exit(1);
    }                                       

    private void admBtnActionPerformed(java.awt.event.ActionEvent evt) {                                       
        // TODO add your handling code here:
        final JDialog bwin = new JDialog();
              
        AdmissionWindow admsnWindow = new AdmissionWindow();
        
        bwin.add(admsnWindow);
        bwin.pack();
        bwin.setVisible(true);
        
   }                                      

    private void libBtnActionPerformed(java.awt.event.ActionEvent evt) {                                       
        
        JOptionPane optionPane = new JOptionPane("Is this what you need?", JOptionPane.QUESTION_MESSAGE,JOptionPane.YES_NO_OPTION);
                JDialog dialog = optionPane.createDialog("Dialog");
                dialog.setVisible(true);
    }                                      

    private void lveBtnActionPerformed(java.awt.event.ActionEvent evt) {                                       
        // TODO add your handling code here:
        final JDialog bwin = new JDialog();
              
        LeaveWindow lveWindow = new LeaveWindow();
        
        bwin.add(lveWindow);
        bwin.pack();
        bwin.setVisible(true);
    }                                      

    private void accBtnActionPerformed(java.awt.event.ActionEvent evt) {                                       
        // TODO add your handling code here:
        final JDialog bwin = new JDialog();
              
        AccountWindow accWindow = new AccountWindow();
        
        bwin.add(accWindow);
        bwin.pack();
        bwin.setVisible(true);
    }                                      

    private void fclBtnActionPerformed(java.awt.event.ActionEvent evt) {                                       
        // TODO add your handling code here:
        final JDialog bwin = new JDialog();
              
        FacultyWindow fclWindow = new FacultyWindow();
        
        bwin.add(fclWindow);
        bwin.pack();
        bwin.setVisible(true);
    }
    private void jTextField1ActionPerformed(java.awt.event.ActionEvent evt) {                                            
        // TODO add your handling code here:
    }                                           

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        GraphicsEnvironment ge = GraphicsEnvironment.getLocalGraphicsEnvironment();
        GraphicsDevice gd = ge.getDefaultScreenDevice();
        
        if (!gd.isWindowTranslucencySupported(TRANSLUCENT)) {
        System.err.println("Translucency is not supported");
        System.exit(0);
        }
        
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(SmsGUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(SmsGUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(SmsGUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(SmsGUI.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
         //       new SmsGUI().setVisible(true);
                SmsGUI tw = new SmsGUI();
                tw.setOpacity(0.80f);
                tw.setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify                     
    private javax.swing.JButton accBtn;
    private javax.swing.JPanel activityPanel;
    private javax.swing.JButton admBtn;
    private javax.swing.JButton crsBtn;
    private javax.swing.JButton exitBtn;
    private javax.swing.JButton fclBtn;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JPasswordField jPasswordField1;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JButton libBtn;
    private javax.swing.JPanel loginPanel;
    private javax.swing.JPanel logoPanel;
    private javax.swing.JButton lveBtn;
    private javax.swing.JButton stdtBtn;
    // End of variables declaration                   
}
