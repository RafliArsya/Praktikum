import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.DefaultComboBoxModel;
import java.awt.event.ItemListener;
import java.awt.event.ItemEvent;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JRadioButton;
import javax.swing.ButtonGroup;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;

public class Main {

	private JFrame frame;
	private JTextField textField;
	private JTextField textField_1;
	private JTextField textField_2;
	private final ButtonGroup buttonGroup = new ButtonGroup();
	//private JLabel lblLabela, lblLabelb, lblLabelc;
	
	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Main() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 450, 300);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		JLabel lblLabela = new JLabel("LabelA");
		lblLabela.setBounds(10, 58, 79, 14);
		frame.getContentPane().add(lblLabela);
		
		JLabel lblLabelb = new JLabel("LabelB");
		lblLabelb.setBounds(10, 99, 79, 14);
		frame.getContentPane().add(lblLabelb);
		
		JLabel lblLabelc = new JLabel("LabelC");
		lblLabelc.setBounds(107, 170, 79, 14);
		frame.getContentPane().add(lblLabelc);
		
		textField = new JTextField();
		textField.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent e) {
				char c=e.getKeyChar();
				if(!(Character.isDigit(c)||(c==KeyEvent.VK_BACK_SPACE)||c==KeyEvent.VK_DELETE||e.getKeyChar() == '.')||textField.getText().length()>12){//  evt.getKeyChar() == '.' does accept point when jtextfield accepts decimal number
					e.consume();
					}
				if(e.getKeyChar()=='.' && textField.getText().contains(".")){
				      e.consume();
				    }  
			}
		});
		textField.setBounds(84, 55, 88, 20);
		frame.getContentPane().add(textField);
		textField.setColumns(10);
		
		textField_1 = new JTextField();
		textField_1.addKeyListener(new KeyAdapter() {
			@Override
			public void keyTyped(KeyEvent e) {
				char c=e.getKeyChar();
				if(!(Character.isDigit(c)||(c==KeyEvent.VK_BACK_SPACE)||c==KeyEvent.VK_DELETE||e.getKeyChar() == '.')||textField.getText().length()>12){//  evt.getKeyChar() == '.' does accept point when jtextfield accepts decimal number
					e.consume();
					}
				if(e.getKeyChar()=='.' && textField.getText().contains(".")){
				      e.consume();
				    }
			}
		});
		textField_1.setColumns(10);
		textField_1.setBounds(84, 96, 88, 20);
		frame.getContentPane().add(textField_1);
		
		textField_2 = new JTextField(0);
		textField_2.setColumns(0);
		textField_2.setBounds(171, 170, 86, 20);
		frame.getContentPane().add(textField_2);
		textField_2.setEditable(false);
		
		JLabel lblLabelhasil = new JLabel("Labelhasil");
		lblLabelhasil.setBounds(267, 173, 79, 14);
		frame.getContentPane().add(lblLabelhasil);
		
		JRadioButton rdbtnRadioa = new JRadioButton("KPH");
		rdbtnRadioa.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				if(rdbtnRadioa.isSelected()) {
					lblLabelhasil.setText(rdbtnRadioa.getText());
				}
			}
		});
		buttonGroup.add(rdbtnRadioa);
		rdbtnRadioa.setBounds(150, 197, 75, 23);
		frame.getContentPane().add(rdbtnRadioa);
		rdbtnRadioa.setSelected(true);
		
		JRadioButton rdbtnRadiob = new JRadioButton("MPH");
		rdbtnRadiob.addItemListener(new ItemListener() {
			public void itemStateChanged(ItemEvent arg0) {
				if(rdbtnRadiob.isSelected()) {
					lblLabelhasil.setText(rdbtnRadiob.getText());
				}
			}
		});
		buttonGroup.add(rdbtnRadiob);
		rdbtnRadiob.setBounds(230, 197, 75, 23);
		frame.getContentPane().add(rdbtnRadiob);
		
		lblLabelhasil.setText(rdbtnRadioa.getText());
		
		JComboBox comboBox_1 = new JComboBox();
		comboBox_1.setModel(new DefaultComboBoxModel(new String[] {"Meter", "Kilometer"}));
		comboBox_1.setBounds(175, 96, 79, 20);
		frame.getContentPane().add(comboBox_1);
		
		JComboBox comboBox_2 = new JComboBox();
		comboBox_2.setModel(new DefaultComboBoxModel(new String[] {"Seconds", "Minutes", "Hours"}));
		comboBox_2.setBounds(175, 55, 79, 20);
		frame.getContentPane().add(comboBox_2);
		
		JComboBox comboBox = new JComboBox();
		comboBox.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				if (comboBox.getSelectedIndex() == 0) {
					lblLabela.setText("Waktu");
					lblLabelb.setText("Jarak");
					lblLabelc.setText("Kecepatan");
					rdbtnRadioa.setBounds(150, 197, 75, 23);
					rdbtnRadiob.setBounds(230, 197, 75, 23);
					comboBox_1.setBounds(175, 96, 79, 20);
					comboBox_2.setBounds(175, 55, 79, 20);
					lblLabelhasil.show();
				}else if(comboBox.getSelectedIndex() == 1) {
					lblLabelb.setText("Waktu");
					lblLabelc.setText("Jarak");
					lblLabela.setText("Kecepatan");
					rdbtnRadioa.setBounds(175, 55, 75, 23);
					rdbtnRadiob.setBounds(255, 55, 75, 23);
					comboBox_1.setBounds(265, 170, 79, 20);
					comboBox_2.setBounds(175, 96, 79, 20);
					lblLabelhasil.hide();
				}else {
					lblLabelc.setText("Waktu");
					lblLabela.setText("Jarak");
					lblLabelb.setText("Kecepatan");
					rdbtnRadioa.setBounds(175, 95, 75, 23);
					rdbtnRadiob.setBounds(255, 95, 75, 23);
					comboBox_1.setBounds(175, 55, 79, 20);
					comboBox_2.setBounds(265, 170, 79, 20);
					lblLabelhasil.hide();
				}
			}
		});
		comboBox.setModel(new DefaultComboBoxModel(new String[] {"Kecepatan", "Jarak", "Waktu"}));
		comboBox.setBounds(10, 11, 120, 20);
		frame.getContentPane().add(comboBox);
		
		lblLabela.setText("Waktu");
		lblLabelb.setText("Jarak");
		lblLabelc.setText(comboBox.getSelectedItem().toString());
		
		JButton btnHitung = new JButton("Hitung!");
		btnHitung.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				int sel = comboBox.getSelectedIndex();
				String text_a = textField.getText().toString();
				String text_b = textField_1.getText().toString();
				Double a = Double.parseDouble(text_a);
				Double b = Double.parseDouble(text_b);
				double c = 0;
				switch(sel) {
				case 0 :
					 if(comboBox_2.getSelectedIndex() == 0) {
						 a /= 3600;
					 }else if(comboBox_2.getSelectedIndex() == 1) {
						 a /= 60;
					 }else {
						 //do Nothing
					 }
					 if(comboBox_1.getSelectedIndex() == 0) {
						 b /= 1000;
					 }
					 if(rdbtnRadioa.isSelected()) {
						 c=b/a;
					 }
					 if(rdbtnRadiob.isSelected()) {
						 c=b/a;
						 c/=1.609344;
					 }
					 //String text_c = String.valueOf(c);
					 String hasil = String.format("%.2f", c);
					 textField_2.setText(hasil);
					 break;
				case 1 :
					
				case 2 :
					
				default:
					textField_2.setText("ERROR");
				}
			}
		});
		btnHitung.setBounds(168, 136, 89, 23);
		frame.getContentPane().add(btnHitung);
		
	}
}
