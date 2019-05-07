package sample;

import javafx.beans.property.SimpleStringProperty;
import javafx.beans.property.StringProperty;

public class Stock {
	private final StringProperty ticker;
	private final StringProperty exDivDate;
	private final StringProperty dividend;

	public Stock(String ticker,String exDivDate,String dividend){
		this.ticker = new SimpleStringProperty(ticker);
		this. exDivDate = new SimpleStringProperty(exDivDate);
		this.dividend = new SimpleStringProperty(dividend);
	}

	public  Stock(String ticker,String exDivDate){
		this(ticker,exDivDate,null);
	}

	public  Stock(String ticker){
		this(ticker,null,null);
	}

	public  Stock(){
		this(null,null,null);
	}

	public String getTicker() {
		return ticker.get();
	}

	public void setTicker(String ticker) {
		this.ticker.set(ticker);
	}

	public StringProperty tickerProperty(){
		return ticker;
	}

	public String getExDivDate() {
		return exDivDate.get();
	}

	public void setExDivDate(String exDivDate) {
		this.exDivDate.set(exDivDate);
	}

	public StringProperty exDivDateProperty(){
		return exDivDate;
	}

	public String getDividend() {
		return dividend.get();
	}

	public void setDividend(String dividend) {
		this.dividend.set(dividend);
	}

	public  StringProperty dividendPropety(){
		return dividend;
	}
}
