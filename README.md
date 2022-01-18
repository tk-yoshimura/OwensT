# OwensT

Generate Owen's T Function Expected Value

## Definition

![define](https://github.com/tk-yoshimura/OwensT/blob/main/figures/define.svg)  

## Special Values

![special values](https://github.com/tk-yoshimura/OwensT/blob/main/figures/svalue.svg)  
![limit](https://github.com/tk-yoshimura/OwensT/blob/main/figures/svalue_limit.svg)  

## Properties

![symmetry](https://github.com/tk-yoshimura/OwensT/blob/main/figures/symmetry.svg)  
![large_a](https://github.com/tk-yoshimura/OwensT/blob/main/figures/large_a.svg)  

## Expected Value Generation

The Fast algorithm by Patefield and Tandy et al. is a method that uses six different algorithms depending on the region.
However, at accuracies higher than double, the algorithms diverge in some cases and approximations cannot be obtained.
Among the six algorithms, the Gaussian quadrature-based generation method is the most applicable to a wide range of domains and is stable without worrying about loss of digits.
In addition, since it is an even function, only half of the evaluation points in the quadrature method are needed.

![t5algo](https://github.com/tk-yoshimura/OwensT/blob/main/figures/t5algo.svg)  
[Gaussian quadrature Sampling Points](https://github.com/tk-yoshimura/LegendrePolynomialRoot)  

When h is large, the Gaussian quadrature method may not be able to correctly calculate because integrand f takes a small value in the region where x is large and the sample points are concentrated.

![integrand](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand.svg)  
![integrand_plot](https://github.com/tk-yoshimura/OwensT/blob/main/figures/integrand_plot.svg)  

The definite integral of only the numerator of f can be obtained explicitly. When h is large, f and g become very close. 
The function d is always negative.

![delta df](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta_df.svg)  

![delta](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta.svg)  
![delta peak](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta_peak.svg)  

![delta plot](https://github.com/tk-yoshimura/OwensT/blob/main/figures/delta_plot.svg)  
![peak plot](https://github.com/tk-yoshimura/OwensT/blob/main/figures/peak_plot.svg)  

The equation that expands the range of application of the T5 algorithm by censoring a when h is large is as follows:

a &leq; 4 or h &geq; 4:  
![t5modalgo](https://github.com/tk-yoshimura/OwensT/blob/main/figures/t5modalgo.svg)  
![t5modalgo_plot](https://github.com/tk-yoshimura/OwensT/blob/main/figures/t5modalgo_plot.svg)  

a &gt; 4 and h &lt; 4:  
Outside the region the above equation, it can be calculated using the properties 2 formula.
Also, in the region where erf(ha/sqrt(2)) can be regardes as 1, it can be calculated using the limit formula.

## Reference

Owen, D B. "Tables for computing bivariate normal probabilities". Annals of Mathematical Statistics, 27, 1075–1090. (1956)  
Patefield, M. and Tandy, D. "Fast and accurate Calculation of Owen’s T-Function", Journal of Statistical Software, 5 (5), 1–25. (2000) 