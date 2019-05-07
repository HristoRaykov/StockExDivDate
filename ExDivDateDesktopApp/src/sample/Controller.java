package sample;


import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.scene.control.*;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.select.Elements;

import java.io.IOException;


public class Controller {
    public TextField tickers;
    public TableView<Stock> stockTable;
    public TableColumn<Stock,String> colTicker ;
    public TableColumn<Stock,String> colExDivDate;
    public TableColumn<Stock,String> colDividend;


    public void getData(ActionEvent actionEvent) {

        ObservableList<Stock> stockDataTable = FXCollections.observableArrayList();
        ObservableList<String> tickerData = FXCollections.observableArrayList (tickers.getText().trim().split(" "));
        Document htmlDoc;

        try {
            for (int counter = 0; counter < tickerData.size(); counter++) {
                htmlDoc = getHTML(tickerData.get(counter));
                if (htmlDoc != null) {
                    stockDataTable.add(new Stock(tickerData.get(counter),getExDivDate(htmlDoc).trim(),getDividendAmount(htmlDoc).trim()));
                }else{
                    stockDataTable.add(new Stock(tickerData.get(counter),"No Data","No Data"));
                }



            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        colTicker.setCellValueFactory(cellData -> cellData.getValue().tickerProperty());
        colExDivDate.setCellValueFactory(cellData -> cellData.getValue().exDivDateProperty());
        colDividend.setCellValueFactory(cellData -> cellData.getValue().dividendPropety());
        stockTable.setItems(stockDataTable);

    }

    private static Document getHTML(String ticker) throws IOException {
        String url;

        if (ticker.contains("p")) {
            url = "https://eresearch.fidelity.com/eresearch/evaluate/quote.jhtml?symbols="
                    + ticker.split("p")[0] + "%2FP" + ticker.split("p")[1];
        } else {
            url = "https://eresearch.fidelity.com/eresearch/evaluate/quote.jhtml?symbols=" + ticker;
        }

        return Jsoup.connect(url).get();
    }

    private static String getExDivDate(Document htmlDoc) {

        Elements elem = null;

        boolean isPref = htmlDoc.select("th:contains(Ex-Dividend Date)").size() != 0;
        boolean isFund = htmlDoc.select("th:contains(Ex-Date)").size() != 0;

        if (isPref) {
            elem = htmlDoc.select("th:contains(Ex-Dividend Date)").next();
        } else if (isFund) {
            elem = htmlDoc.select("th:contains(Ex-Date)").next();
        }

        if (elem != null) {
            return elem.text();
        } else {
            return "No data";
        }
    }

    private static String getDividendAmount(Document htmlDoc) {

        Elements elem = null;

        boolean isPref = htmlDoc.select("th:contains(Dividend)").size() != 0;
        boolean isFund = htmlDoc.select("th:contains(Most Recent Distribution)").size() != 0;

        if (isPref) {
            elem = htmlDoc.select("th:contains(Dividend)").eq(2).next();
        } else if (isFund) {
            elem = htmlDoc.select("th:contains(Most Recent Distribution)").next();
        }

        if (elem != null) {
            return elem.text();
        } else {
            return "No data";
        }
    }

}
