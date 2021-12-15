 @Override
    public void actionPerformed(ActionEvent event) {
      String tmpdir = System.getProperty("java.io.tmpdir");
      System.out.println(
        "The default value of the java.io.tmpdir system property is: \"" +
        tmpdir +
        "\"\n"
      );
      String prefix = "Logistics_";
      String suffix = ".csv";

      File tempFile = null;

      try {
        //Create two temporary files.
        tempFile = File.createTempFile(prefix, suffix);
      } catch (IOException ex) {
        System.err.println("An IOException was caught: " + ex.getMessage());
        ex.printStackTrace();
      }
      System.out.println(
        "A new file called \"" +
        tempFile.getName() +
        "\" was created in the directory: \"" +
        tmpdir +
        "\""
      );

      //Printing the parent directories of every file.
      System.out.println(
        "The parent directory of the file \"" +
        tempFile.getName() +
        "\" is: \"" +
        tempFile.getParent() +
        "\""
      );

      String fileName = (tempFile.getParent() + "\\" + tempFile.getName());

      File myObj = new File(fileName);

      //Check whether file exists
      if (!myObj.exists()) System.out.println("File not exists"); else {
        String Unit = "";
        try {
          FileWriter csvwriter = new FileWriter(fileName, true);
          csvwriter.append("Name");
          csvwriter.append(";");
          csvwriter.append("Package Content");
          csvwriter.append(";");
          csvwriter.append("Package Size");
          csvwriter.append(";");
          csvwriter.append("Select Unit");
          csvwriter.append(";");
          csvwriter.append("Delivery City");
          csvwriter.append(";");
          csvwriter.append("\n");

          csvwriter.append(nameText.getText());
          csvwriter.append(";");
          csvwriter.append(packageContText.getText());
          csvwriter.append(";");
          csvwriter.append(packageSizeText.getText());
          csvwriter.append(";");

          if (m3RButton.isSelected()) Unit = "m3";
          if (kgRButton.isSelected()) Unit = "kg";

          csvwriter.append(Unit);

          csvwriter.append(";");
          csvwriter.append((CharSequence) deliveryCityComb.getSelectedItem());
          csvwriter.append(";");
          csvwriter.append("\n");
          csvwriter.close();
          System.out.println("CSV file created succesfully.");
        } catch (Exception e) {
          System.out.println("exception :" + e.getMessage());
        }
      }
    }
