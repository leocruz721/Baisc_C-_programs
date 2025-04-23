def check_insurance_eligibility():
    # Get user input
    age = int(input("What is your age? "))
    has_dui = input("Have you ever had a DUI? (yes or no) ").strip().lower()
    speeding_tickets = int(input("How many speeding tickets do you have? "))

    # Convert DUI answer to boolean
    dui = has_dui == "yes"

    # Apply qualification rules
    is_eligible = (age > 15) and (not dui) and (speeding_tickets <= 3)

    # Print the result
    print(is_eligible)

# Run the function
check_insurance_eligibility()
